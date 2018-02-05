using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Rigidbody2D rb2d;
    bool landed;
	// Use this for initialization
	void Start () {
        landed = false;
        rb2d=GetComponent<Rigidbody2D>();
	}

    public void Landed()
    {
        //Debug.Log("Aja!");
        landed = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(new Vector3(15,0,0),ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(new Vector3(-15, 0, 0), ForceMode2D.Force);
        }

        if (Input.GetKeyDown(KeyCode.Space)&&landed)
        {
            rb2d.AddForce(new Vector3(0, 13, 0), ForceMode2D.Impulse);
            landed = false;
        }

        if (rb2d.velocity.x > 80)
        {
            rb2d.velocity = new Vector2(80,rb2d.velocity.y);
        }

        if (rb2d.velocity.x < -80)
        {
            rb2d.velocity = new Vector2(-80, rb2d.velocity.y);
        }
    }
}
