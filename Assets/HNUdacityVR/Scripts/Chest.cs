
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour 
{


   // public AudioClip objectSound;
   // public AudioSource objectAudioSource;

    public GameObject PoofParticles1;
    //public GameObject PoofParticles2;


	void Start()
	{
		
	}
    void Update()
    {
        //Not required

    }
	
	public void PoofOnClick() 
	{

		// If the door is clicked 
         
        Debug.Log ("Chest / PoofOnClick");
        //objectAudioSource.PlayOneShot(objectSound);

        Instantiate(PoofParticles1);
       // Instantiate(PoofParticles2);

        // Make sure the poof animates vertically
        PoofParticles1.transform.position = gameObject.transform.position;
       // PoofParticles2.transform.position = gameObject.transform.position;


		
		
	}
		
}
