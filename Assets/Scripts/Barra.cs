using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D) && transform.position.x < 689)
        {
            transform.position = new Vector3(transform.position.x + 20, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x > -689)
        {
            transform.position = new Vector3(transform.position.x - 20, transform.position.y, transform.position.z);
        }
    }
}
