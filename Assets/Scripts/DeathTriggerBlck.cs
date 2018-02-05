using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTriggerBlck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectsWithTag("Rompibles").Length<=0)
        {
            SceneManager.LoadScene("Vista2");
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bolita"))
        {
            if (SceneManager.GetActiveScene().name.Equals("BlockBrkrSkate"))
            {
                SceneManager.LoadScene("BlockBrkrSkate");
            }

            if (SceneManager.GetActiveScene().name.Equals("BlockBrkrProto"))
            {
                SceneManager.LoadScene("BlockBrkrProto");
            }
        }
    }
}
