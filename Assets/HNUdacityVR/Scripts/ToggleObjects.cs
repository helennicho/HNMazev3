using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjects : MonoBehaviour {

    public GameObject Object1;
    public GameObject Object2;
	// Use this for initialization
	void Start () {
        Object1.SetActive(true);
        Object2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCLick(){
        Object1.SetActive(false);
        Object2.SetActive(true);
    }
}
