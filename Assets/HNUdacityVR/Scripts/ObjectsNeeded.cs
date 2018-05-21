using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsNeeded : MonoBehaviour {
    // not needed anymore
    // perhaps to handle array of objects tobe collected - see Gamelogic Object and script
    public int objectCount;
    public bool objectsNeeded = true;

    // call GameLogic when 5 objects collected
    public GameLogic gameLogic;

	// Use this for initialization
	void Start () {
        objectCount = 0;
        Debug.Log("in ObjectsNeeded/Start - objectCount " + objectCount);
	}

    // Update is called once per frame
    void Update()
    { }

    public void countObjects()
    {
        objectCount++;
        Debug.Log("in ObjectsNeeded/countObjects                                  - objectCount " + objectCount);
        //print objects collected on canvas
        if (objectCount >= 5)
        {
            objectsNeeded = false;
            //print go to temple door on canvas

            gameLogic.HasOtherObjects();

        }
        else
        {
            // print need to collect 5 objects on canvas

        }
    }


}
