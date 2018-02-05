using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour {
    bool touched;
    Rigidbody2D rb2d;
    float timeFall;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        touched = false;
        timeFall=0.5f;
	}
	
	// Update is called once per frame
	void Update () {
        if (touched)
        {
            timeFall -= Time.deltaTime;
        }
        if (timeFall <= 0)
        {
            rb2d.bodyType = RigidbodyType2D.Dynamic;
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<Player>().Landed();
            touched = true;
        }
    }
}
