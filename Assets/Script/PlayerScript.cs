using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public float speed = 5f;
    float posx = 0f;
    float posy = 0f;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Player");
        posx = Input.GetAxis("Horizontal") * speed;
        posy = Input.GetAxis("Vertical") * speed;
        Vector3 direction = new Vector3(posx, 0, posy);
	}
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(posx, 0, posy);
    }
}
