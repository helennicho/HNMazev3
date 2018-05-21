using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour {

    public GameObject PoofParticles;

    // call ObjectNeeded to keep countof objects collected
    public GameLogic gameLogicObject;
    public AudioClip objectSound;
    public AudioSource objectAudioSource;
    // Use this for initialization

	void Start () 
    {
    }
	
	// Update is called once per frame
	void Update ()
    {	
	}

    public void OnCollectablesClicked()
    {
        // Instantiate the Poof particale Prefab where this coin is located
        Debug.Log("in Collectables/OnCollectablesClicked ");
        objectAudioSource.PlayOneShot(objectSound);

        //PoofParticles.SetActive(true);
        Instantiate(PoofParticles);
        // Make sure the poof animates vertically
        PoofParticles.transform.position = gameObject.transform.position;
       

        // Call the GameLogic.countObjectscollected (GameObject collectable) method (see GameLogic.cs script) passing in the orb         gameLogicObject.CountOtherObjectsCollected(this.gameObject);
       

        // Destroy this object so no longer there to be collected. Check the Unity documentation on how to use Destroy
        Destroy(gameObject, 0.5f);

    }

}



// or could use ...
// Instantiate(PoofParticles, transform.position, Quaternion.Euler(-90f, 0f, 0f))
