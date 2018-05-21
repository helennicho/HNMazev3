using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleDoor : MonoBehaviour 
{


    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	public bool locked;
    // Create a boolean value called "opening" that can be checked in Update() 
    public bool opening; 
	public AudioClip openGate; 
	public AudioClip closeGate;
	public AudioSource doorSound;
    public GameObject canvasUI;

	void Start()
	{
		//Debug.Log ("TempleDoor - at start set locked = true");
		locked = true;
		opening = false;
        canvasUI.SetActive(false);
	}

   void Update()
   
	{
		// If the door is opening and it is not fully raised
		// Animate the door raising up
		if (opening == true && !locked) 
		{
			//Debug.Log ("TempleDoor/Update() : in update - opening the door so long as it is not already opened");
            if (transform.position.y == 5f)
            {
                opening = false;
            }
            else if (transform.position.y < 5f)
			{
				transform.Translate (0, 3.0f * Time.deltaTime, 0, Space.World);
				doorSound.PlayOneShot (openGate);
			}
		}
	}
       
    public void OnDoorClicked() 
	{
		Debug.Log ("TempleDoor/OnDoorClicked : about to check if locked == false)");
		// If the door is clicked and unlocked
		// Set the "opening" boolean to true
        canvasUI.SetActive(false);
		if (locked == false) 
		{
			Debug.Log ("TempleDoor/OnDoorCLicked : clicked & not locked  so open door");
			opening = true; // door takes a while to open so do this in update
		}
		else 
		{
			// (optionally) Else Play a sound to indicate the door is locked
			Debug.Log ("TempleDoor/OnDoorCLicked :door clicked but locked");// play a sound
            canvasUI.SetActive(true);
            opening = false; 
			doorSound.PlayOneShot(closeGate);
            //SetInactiveAfterSeconds
            StartCoroutine("InactivateCanvasAfter3Seconds");
          

		}  
    }

    public void Unlock()
    {
		locked = false; // You'll need to set "locked" to false here
		Debug.Log ("TempleDoor/Unlock() : set door to not locked");// play a sound
    }
    IEnumerator InactivateCanvasAfter3Seconds()
    {
        yield return new WaitForSeconds(3.0f);
        canvasUI.SetActive(false);
    }

   
}
