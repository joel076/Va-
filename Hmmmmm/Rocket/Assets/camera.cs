using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public GameObject naic;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mouse = Input.mousePosition;
		if (true) {
			Vector3 v3T = new Vector3 (Input.GetAxis("Vertical"), -Input.GetAxis("Horizontal"), 0.0f);
			transform.Rotate (v3T *0,1f);
		}
	}
}
