using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//Rota el elemento una cantidad diferente en cada dirección y enc ada intervalo de tiempo
		transform.Rotate(new Vector3(80,0,0) * Time.deltaTime);
	}

}
