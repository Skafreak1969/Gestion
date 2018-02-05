using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().name.Equals("PlatStreet"))
            {
                SceneManager.LoadScene("PlatStreet");
            }
            if (SceneManager.GetActiveScene().name.Equals("PlatRock"))
            {
                SceneManager.LoadScene("PlatRock");
            }
        }
    }
}
