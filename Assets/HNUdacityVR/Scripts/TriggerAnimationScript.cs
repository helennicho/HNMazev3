using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Trigger Animation Script - perform animation on trigger of Google Cardboard animation
public class TriggerAnimationScript : MonoBehaviour 
{

   
    [Tooltip("The Animator component on this gameobject")]
    public Animator animator;
    [Tooltip("The name of the animator trigger parameter")]
    public string triggerName;

    // Use this for initialization
	void Start ()
    {
		
	}
	
	/*
	// Update is called once per frame
    // so would clash with waypoints and any other trigger - wantto limit animation to onclick game object
	void Update () 
    {
        // if player pressed the cardborad trigger
        if (Input.GetMouseButtonDown(0) ) 
        {
            animator.SetTrigger(triggerName);
        }
	}

    */

   // ideally want to click on object to trigger animation
    void OnClick()
    {
        animator.SetTrigger(triggerName);
    }


}
