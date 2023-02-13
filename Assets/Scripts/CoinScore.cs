using UnityEngine;
using System.Collections;

public class CoinScore : MonoBehaviour {

	public AudioSource coinSound;


	private void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			coinSound.Play();
		}
	}
}
