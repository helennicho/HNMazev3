

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoor : MonoBehaviour
{



    // Create a boolean value called "opening" that can be checked in Update() 
    public bool dlocked;
    public bool dopening;
    public AudioClip openGate;
    public AudioClip closeGate;
    public AudioSource doorSound;
    public GameObject canvasUI;


    void Start()
    {
        //Debug.Log ("MainDoor at start set opening = false");
        dlocked = true;
        dopening = false;
        canvasUI.SetActive(false);
    }

    void Update()

    {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (dopening == true && !dlocked)
        {
            //Debug.Log ("MainDoor/Update() : opening the door so long as it is not already opened");

            if (transform.position.y == 5f)
            {
                dopening = false;
            }
            else if (transform.position.y < 5f)
            {
                transform.Translate(0, 3.0f * Time.deltaTime, 0, Space.World);
                doorSound.PlayOneShot(openGate);
            }
        }
    }


    public void OnDoorClicked()
    {
        Debug.Log("MainDoor/OnDoorClicked : about to check if locked == false)");
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        canvasUI.SetActive(false);
        if (dlocked == false)
        {
            Debug.Log("MainDoor/OnDoorCLicked : clicked & not locked  so open door");
            dopening = true; // door takes a while to open so do this in update
        }
        else
        {
            // (optionally) Else Play a sound to indicate the door is locked
            Debug.Log("MainDoor/OnDoorCLicked :door clicked but locked");// play a sound
            canvasUI.SetActive(true);
            dopening = false;
            doorSound.PlayOneShot(closeGate);
            //Set canvas inactive after 3 secs
            StartCoroutine("InactivateCanvasAfter3Seconds");

        }
    }

    public void Unlock()
    {
        dlocked = false; // You'll need to set "locked" to false here
        Debug.Log("MainDoor/Unlock() : set door to not locked");// play a sound
    }

    IEnumerator InactivateCanvasAfter3Seconds()
    {
        yield return new WaitForSeconds(3.0f);
        canvasUI.SetActive(false);
    }
}


