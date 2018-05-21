using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaker2 : MonoBehaviour {
 // Set the object to be cloned in the Inspector. Use a Prefab from Project NOT Scene! 
	public GameObject objectToCreate;

	// to generalise position of object instantiated use a var spawnpoint
	// public Transform spawnPoint;
	// also see InstantiateExamples.cs

	// Use this for initialization
	void Start() {
		// for loop for multiple instances
		for (int i=0; i<10; i++){
		// make object
			// to generalise use ... spawnPoint.position instead on new Vector3(x,y,z)
			// simple example - Instantiate(prefab, transform);
			Object.Instantiate(objectToCreate, new Vector3(0, 0, i), Quaternion.identity);
			// or might be able to use ... 

			//GameObject p = Instantiate(prefab, transform.position, Quaternion.identity) as GameObject; // Make this clone a child of the gameObject that spawned it
			//p.transform.parent = transform;
			// This approach allows you to further manipulate the cloned prefab in this script. Such as... // Destroying the clone after a set amount of time
			// Destroy(p, 3f);
		}
	}

	void Update () {
			
	}

	}