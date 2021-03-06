﻿using UnityEngine;
using System.Collections;

public class blinkD : MonoBehaviour {

	public float blinkSpeed = 1f;

	// Use this for initialization
	void OnEnable () {
		if(gameObject.GetComponent<Renderer>()!=null) 
			StartCoroutine(BlinkRenderer());

		if(gameObject.GetComponent<GUIText>()!=null) 
			StartCoroutine(BlinkGuiText());
		if(gameObject.GetComponent<Light>()!=null) 
			StartCoroutine(BlinkLight());




	}

	IEnumerator BlinkRenderer() {
		while(true) {
			yield return new WaitForSeconds(blinkSpeed/2f);
			gameObject.GetComponent<Renderer>().enabled = false;
			yield return new WaitForSeconds(blinkSpeed/2f);
			gameObject.GetComponent<Renderer>().enabled = true;
		}
	}

	IEnumerator BlinkGuiText() {
		while(true) {
			yield return new WaitForSeconds(blinkSpeed/2f);
			gameObject.GetComponent<GUIText>().enabled = false;
			yield return new WaitForSeconds(blinkSpeed/2f);
			gameObject.GetComponent<GUIText>().enabled = true;
		}
	}

	IEnumerator BlinkLight() {
		while(true) {
			yield return new WaitForSeconds(blinkSpeed/2f);
			gameObject.GetComponent<Light>().enabled = false;
			yield return new WaitForSeconds(blinkSpeed/2f);
			gameObject.GetComponent<Light>().enabled = true;
		}
	}

}
