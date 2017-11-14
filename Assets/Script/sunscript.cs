using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("sun");
        transform.rotation = transform.rotation * Quaternion.Euler(Time.deltaTime, 0, 0);
	}
}
