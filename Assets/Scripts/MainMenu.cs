using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void ESCJuego(){
		SceneManager.LoadScene("Escena01");
	}

	public void ESCControles(){
		SceneManager.LoadScene("Controles");
	}

	public void ESCMainMenu(){
		SceneManager.LoadScene("Menu");
	}
}
