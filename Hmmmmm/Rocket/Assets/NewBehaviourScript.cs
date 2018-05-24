using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public float adder = 20;
    public bool kind = true;
    public float speed;
    float hAxis;
    float vAxis;
    public int trumps = 0;
    CharacterController controller;
    public Text MyText;
    public float jumpSpeed = 50000000000000f;
	public Rigidbody prefab;
    public Rigidbody trumpfab;
	public Transform Place;
	public Transform target;
    public Rigidbody Place2;
    public Text waow;
    GameObject Target2;
    float damping = 100f;
    System.Random r = new System.Random();
    public Vector3 jump;
    public float jumpForce = 2.5f;
    public bool isGrounded;
    public static float spawnCount = 20;

    // Use this for initialization
    void Start () {
        Debug.Log(spawnCount);
        kind = true;
        waow.enabled = false;
        Target2 = GameObject.Find ("Main Camera");
        Place2 = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        for (int x = 0; x < spawnCount; x++) {
            Rigidbody n;
            n = Instantiate(trumpfab, new Vector3(r.Next(-100,100),15,r.Next(-100,100)), Quaternion.Euler(new Vector3(0, r.Next(5, 300), 0))) as Rigidbody;
        }
        jump = new Vector3(0.0f, 10f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }
    IEnumerator Example()
    {
        waow.enabled = true;
        yield return new WaitForSeconds(3);
        Application.LoadLevel(0);
    }
    // Update is called once per frame
    void Update () {
        if (kind == true) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            kind = !kind;
        }
        if (trumps >= 10) {
            //StartCoroutine(Example());
     
            spawnCount += adder;
            Application.LoadLevel(1);
        }
            MyText.text = "Trumps killed:" + trumps;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20;
        }
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Place2.transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Place2.transform.position += -transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Place2.transform.position += -transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Place2.transform.position += transform.right * Time.deltaTime * speed;
        }


            var lookPos = transform.position - target.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);

        if (Input.GetMouseButtonDown(0)){	
			Rigidbody shot;
			shot = Instantiate (prefab, Place.position, Place.rotation) as Rigidbody;
			shot.AddForce(Place.forward * 10000);
		}

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            Place2.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        
    }

}
