using UnityEngine;
using System.Collections;

public class AudioTrigger : MonoBehaviour {
	public AudioSource sonido1;

	void OnTriggerEnter(){
		sonido1.Play ();
	}
}
