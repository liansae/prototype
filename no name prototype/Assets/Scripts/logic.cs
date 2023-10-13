using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logic : MonoBehaviour
{
    public int numberPeople;
    public bool win = false;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (numberPeople >= 8 && !win)
        {
            win = true;
            StartCoroutine(ActivateCanvasAfterDelay(3f));
            
        }
        Debug.Log(numberPeople);
    }
    private IEnumerator ActivateCanvasAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay
        canvas.SetActive(true); // Activate the canvas after the delay
    }
}
