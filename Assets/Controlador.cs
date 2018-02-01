using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InicioApp()
    {
        SceneManager.LoadScene("Vista2");
    }

    public void ProtoPunk()
    {
        SceneManager.LoadScene("ProtoPunk");
    }
    public void SkatePunk()
    {
        SceneManager.LoadScene("SkatePunk");
    }
    public void StreetPunk()
    {
        SceneManager.LoadScene("StreetPunk");
    }
    public void PunkRock()
    {
        SceneManager.LoadScene("PunkRock");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Vista2");
    }
}
