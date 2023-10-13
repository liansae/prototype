using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CityPeople : MonoBehaviour
{
    private Animator animator;
    private bool isBonked = false;
    private bool hasDanced = false;
    public logic logicScript; 

    private void Start()
    {
        // Get the Animator component attached to the character.
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the tag "Plushie" and the character is not already dancing.
        if (collision.gameObject.CompareTag("Plushie") /*&& !isBonked*/)
        {
            if(hasDanced == false)
            {
                logicScript.numberPeople++;
            }
            // Start the dance animation.
            StartDancing();
            
        }


    }

    private void StartDancing()
    {
        hasDanced = true;
        // Set a trigger parameter in the animator to start the dance animation.
        animator.SetTrigger("isBonked");

        // Set a flag to indicate that the character is now dancing.
        isBonked = true;
    }
}

