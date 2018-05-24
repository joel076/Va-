using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Debug.Log("Working");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0)) {

                Debug.Log("Quit");
                Application.Quit();
            
        }
    }
}
