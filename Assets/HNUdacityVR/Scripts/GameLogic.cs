using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // game logic 
    // need to collect coin to open main door
    // need to 4 other colletable objects AND key to open Temple door
    // display items collected on UI canvas

    // array to hold Collectable objects - ref GameLogic script attached to GameLogic object
    public GameObject[] collectableObjects;



    // create int coin counter
    // coinCount incremented in Coin script - whenevercoin is collected
    public int totalObjectCount = 0; // just a double check that coin, 4 date objects & key are collected
    public int objectCount = 0;
    public int coinCount = 0;

    public bool hasKey = false;
    public bool hasOtherObjects = false;
    public bool hasCoin = false;


    // call TempleDoor to control door opening
    public TempleDoor TdoorOpen;
    public MainDoor MdoorOpen;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame ????
    // just check hasKey & hasDateObjects to open Temple door
    void UpdateCanvas()
    {
        if (!hasCoin){
            // show need coin to open main door on canvas
        }
        if (hasOtherObjects && hasKey)
        {
            Debug.Log("has date objects & key");
            // show coin,date & key on canvas
            // allow temple door to open
            TdoorOpen.Unlock();
        }
        else if (hasOtherObjects && !hasKey)
        {
            Debug.Log("need key");
            // canvas - show need key 
        }
        else if (hasKey && !hasOtherObjects)
        {
            Debug.Log("need full date ");

            // canvas - show need full date day/d/m/y
        }
        else
        {
            Debug.Log("need key & full date");
        }
    }

    public void HasKey()
    {

        if (!hasKey)
        {

            // allows temple door to open
            hasKey = true; // You'll need to set "locked" to false here
            MdoorOpen.Unlock();
            Debug.Log("GameLogic/HasKey - set hasKey true");
            // play a sound
                                         // add key to  Objects array
                                                            // show key collected on canvas
            UpdateCanvas();
        }
    }



    public void HasCoin()
    {
        if (!hasCoin)
        {

            hasCoin = true;
            // allow main door to open
            MdoorOpen.Unlock();

            Debug.Log("in Gamelogic/HasCoin");
            // add coin to  Objects array
            //show coin collected on canvas
            UpdateCanvas();
        }

    }

    public void HasOtherObjects()
    {

        hasOtherObjects = true;
        Debug.Log("in Gamelogic/HasOtherObjects");
        //print go to temple door on canvas
        UpdateCanvas();

    }

    public void CountCoinsCollected()
    {
        // only need 1 coin for this game
        // only do this for 1st coin collected
        coinCount++;
        Debug.Log("in Gamelogic/CountCooinsCollected " + coinCount);
        if (coinCount == 1)
        {
            HasCoin();
        }

    }


    public void CountOtherObjectsCollected(GameObject collectable)
    {
        // count full date object collected day/dd/mm/yyyy
        // note as objects collected they are deleted
       
        objectCount++;
        Debug.Log("in Gamelogic/countOtherObjectsCollected - objectCount " + objectCount);
        //print objects collected on canvas
        if (objectCount >= 4)
        {
            HasOtherObjects();

        }

    }

}


