using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class uiController : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public string[] Sentences;
    private int Index = 0;
    public float DialogueSpeed;
    public Canvas UIMessages;

    // Start is called before the first frame update
    void Start()
    {
        UIMessages.gameObject.SetActive(false);
        Invoke("ShowUI", 1f);
        DialogueText.text = string.Empty;
        StartDialogue();
    }

    void ShowUI()
    {
        UIMessages.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (DialogueText.text == Sentences[Index])
            {
                NextSentence();
            }
            else
            {
                StopAllCoroutines();
                DialogueText.text = Sentences[Index];
            }
        }

        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    ToggleUI();
        //}
        //else
        //{
        //    UIMessages.gameObject.SetActive(true);
        //}
    }

    //void ToggleUI()
    //{
    //    UIMessages.gameObject.SetActive(!UIMessages.gameObject.activeSelf);
    //}

    void StartDialogue()
    {
        Index = 0;
        StartCoroutine(WriteSentence());
    }
    IEnumerator WriteSentence()
    {
        foreach (char Character in Sentences[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);

        }
    }

    void NextSentence()
    {
        if (Index < Sentences.Length - 1)
        {
            Index++;
            DialogueText.text = string.Empty;
            StartCoroutine(WriteSentence());
        }
        else
        {
            UIMessages.gameObject.SetActive(false);
        }
    }
}
