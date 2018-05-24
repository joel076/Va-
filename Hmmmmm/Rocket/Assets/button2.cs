using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {

            Debug.Log("Start");
            Application.LoadLevel(1);

        }
    }
}
