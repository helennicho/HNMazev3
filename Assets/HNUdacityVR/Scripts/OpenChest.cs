
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{


    public GameObject lid;
    // Create a boolean value called "opening" that can be checked in Update() 
    public bool opening;
    public GameObject contents;

    private float Xrotation = 0f;
    public float XrotationRequired;

    // public SignPost displayCanvas;
    public AudioClip openChestSound;
    // public AudioClip closeGate;
    public AudioSource chestAudioSource;


    void Start()
    {
        Debug.Log("Chest() : void Start() opening = false");
        opening = false;
    }

    void Update()

    {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (opening == true)
        {
            
            Debug.Log("Chest/Update() : if chest_opening = true - opening the lid so long as it is not already opened");
            if (Xrotation <= XrotationRequired)
            {

                //using Euler Angles for rotation
                //Debug.Log ("Chest/Update() : lid.transform.eulerAngles.x ");
                // Debug.Log (lid.transform.eulerAngles.x);
                //lid.transform.eulerAngles = new Vector3(lid.transform.eulerAngles.x-0.1f, lid.transform.eulerAngles.y, lid.transform.eulerAngles.z);

                lid.transform.Rotate(1f, 0f, 0f);
                Xrotation = Xrotation + 1f;
                chestAudioSource.PlayOneShot(openChestSound);

            }

            // when chest half open display contents
            // would be best to use animation
            if (Xrotation == (XrotationRequired/2))
            {
                contents.SetActive(true);

            }

            // using deltaTime for rotation
            /*if (transform.position.y < 5f)
            {
                transform.Translate (0, 3.0f * Time.deltaTime, 0, Space.World);
                doorSound.PlayOneShot (openGate);

            }
            */

            else
            {
                Debug.Log("lid completed set rotation so stop");
            }

        }
    }

    public void OnClick()
    {

        // If the door is clicked 
       
        // Set the "opening" boolean to true
        opening = true; // door takes a while to open so do this in update  
        Debug.Log("OpenChest /OnChestClicked : set chest_opening to true");
       

    }

}
