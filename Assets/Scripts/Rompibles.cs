using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rompibles : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Bolita"))
        {
            Destroy(gameObject);
        }
    }
}
