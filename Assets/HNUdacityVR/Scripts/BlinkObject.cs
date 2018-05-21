using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkObject : MonoBehaviour {

    /* attempt 1
     bool fadeIn = true;
       public int seconds;

       // Use this for initialization
       void Start () {

       }

       // Update is called once per frame
       void Update () {

       }


       IEnumerator Toggler()
       {
           yield return new WaitForSeconds(seconds);
           fadeIn = !fadeIn;
       }
       */

    public GameObject blinking_object;
    public float interval;
    public bool isOpen = false;

    void Start()
    {
        
    }

    void FlashLabel()
    {
        if (isOpen)
        {
            if (blinking_object.activeSelf)
                blinking_object.SetActive(false);
            else
                blinking_object.SetActive(true);
        }
    }
    public void OnClickChest()
    {
        isOpen = true;
        InvokeRepeating("FlashLabel", 0, interval);
        FlashLabel();
    }
}