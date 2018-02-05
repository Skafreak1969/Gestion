using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolita : MonoBehaviour {
    Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(-222, -300),ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
        if (rb2d.velocity.x>700)
        {
            rb2d.velocity = (new Vector2(700, rb2d.velocity.y));
        }
        if (rb2d.velocity.y > 700)
        {
            rb2d.velocity = (new Vector2(rb2d.velocity.x,700));
        }
        if (rb2d.velocity.x < -700)
        {
            rb2d.velocity = (new Vector2(-700, rb2d.velocity.y));
        }
        if (rb2d.velocity.y < -700)
        {
            rb2d.velocity = (new Vector2(rb2d.velocity.x, -700));
        }
        Debug.Log(rb2d.velocity.x+" "+rb2d.velocity.y);
    }
}
