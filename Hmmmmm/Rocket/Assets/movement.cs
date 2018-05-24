using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public float speed = 10;
    public AudioClip au;
    public AudioSource aus;
    System.Random ma = new System.Random();
    public Rigidbody trumpobj;
    public Transform trumpPlace;
    public Rigidbody trumpen;
    System.Random ree = new System.Random();
    public float smooth = 1f;

    private Vector3 targetAngles;
    // Use this for initialization
    void Start () {
        aus = GetComponent<AudioSource>();
        //aus.clip = au;
        //StartCoroutine(Example2());
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "wall1")
        {
            Debug.Log("hit");
            transform.Rotate(new Vector3(0, 180, 0) * 100);
        }
    }
    /*IEnumerator Example2()
    {
        while (true) {
            Rigidbody shot;
            shot = Instantiate(trumpobj, trumpPlace.position, trumpPlace.rotation) as Rigidbody;
            shot.AddForce(trumpPlace.forward * 10000);
            yield return new WaitForSeconds(4);
        }
    }*/
    // Update is called once per frame
    void Update () {
       
        transform.position += transform.forward * Time.deltaTime * speed;
        if (ma.Next(1, 500) == 10)
        {
            aus.PlayOneShot(au, 0.7F);
        }
        if (Input.GetKey(KeyCode.H) && ree.Next(0,2) == 1)
        {
            Debug.Log("hit");
            targetAngles = transform.eulerAngles + 180f * Vector3.up; // what the new angles should be

            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, smooth * Time.deltaTime); // lerp to new angles
        }
    }
}
