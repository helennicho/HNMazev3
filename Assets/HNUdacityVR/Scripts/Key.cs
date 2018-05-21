using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject KeyPoof;

    // move doorOpen to GameLogic
    // public TempleDoor doorOpen;
    public GameLogic gameLogic;
    public AudioClip objectSound;
    public AudioSource objectAudioSource;



	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)

	}

	public void OnKeyClicked()
	{
        objectAudioSource.PlayOneShot(objectSound);

        // Instantiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Debug.Log("Key/OnKeyClicked - play KeyPoof particles");// play a soun
        //KeyPoof.SetActive(true); 
		Instantiate(KeyPoof);
		KeyPoof.transform.position = gameObject.transform.position;
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject, 0.5f);

		// or could use ...
		// Instantiate(keyPoof, transform.position, Quaternion.Euler(-90f, 0f, 0f))

        // Call the Unlock() method on the Temple Door
		//doorOpen.Unlock();
        //doorOpen moved to GameLogic

        gameLogic.HasKey();
		// sets the Key Collected Variable - locked to true


    }

}
