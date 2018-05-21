using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollected : MonoBehaviour {

    public GameObject canvasUI;
    public GameObject canvasQuest;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        canvasQuest.SetActive(false);
        canvasUI.SetActive(true);
    }
}
