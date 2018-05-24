using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "trump(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            GameObject.Find("Place").GetComponent<NewBehaviourScript>().trumps++;
        }
    }
}
