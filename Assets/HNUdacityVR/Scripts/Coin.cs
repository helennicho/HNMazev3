using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// compile error says global already exists
public class Coin: MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject CoinParticles;
	
    public GameLogic gameLogic;
    public AudioClip coinSound;
    public AudioSource coinAudio;

	
	void Start() {

	}

	
     void Awake() {
		//if (Instance == null)
			//Instance = this;

		//CoinPoof.SetActive(false);
	}

	void OnDestroy() {
		//if (Instance = this)
			//Instance = null;
	}
	

		
	

	// not sure 9f this is needed (copied Udacity Carnival Carnival Scores script) and used CoinPoof.SetACtive(true)     
		//Object.Instantiate(CoinPoof, new Vector3(2, 4, 6), Quaternion.identity);
	

	
     
    public void OnCoinClicked() {
        coinAudio.PlayOneShot(coinSound);
        Debug.Log("coin/ onclicked");
		// sets the CoinPoof particles GameObject active - not needed if particle prefab instantiated from Project/prefab
        //CoinParticles.SetActive(true);

		Instantiate(CoinParticles);
		// Make sure the poof animates vertically
        CoinParticles.transform.position = gameObject.transform.position;
		// Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy (gameObject, 0.5f);

        // Call the GameLogic.countObjectscollected (GameObject collectable) method (see GameLogic.cs script) passing in the orb 
        gameLogic.CountCoinsCollected();

	}



}
        


        // or could use ...
        // Instantiate(keyPoof, transform.position, Quaternion.Euler(-90f, 0f, 0f))
      
   




