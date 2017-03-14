using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Blink : MonoBehaviour {
	int rand;
	float valor;
	float blinkSpeed;

	void Start (){
	
	
		blinkSpeed = valor;
	
	}
	void Update () {
		
		rand = Random.Range (1, 2);
		if(rand == 1){
			valor = 2.4f;

		}
		if(rand == 2){
			valor = 1f;


		}
		
	}

	// Use this for initialization
	void OnEnable () {









		if(gameObject.GetComponent<Renderer>()!=null) 
			StartCoroutine(BlinkRenderer());

		if(gameObject.GetComponent<GUIText>()!=null) 
			StartCoroutine(BlinkGuiText());
		if(gameObject.GetComponent<Image>()!=null) 
			StartCoroutine(BlinkImage());
		if(gameObject.GetComponent<Light>()!=null) 
			StartCoroutine(BlinkLight());

//		if(gameObject.GetComponent<Renderer>()==null && gameObject.GetComponent<GUIText>()==null) {
//			Debug.LogError("Could NOT Blink object '" + gameObject.name + "' (no Render or GuiText)\n");
//		}

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

	IEnumerator BlinkImage() {
		while(true) {
			yield return new WaitForSeconds(blinkSpeed/2f);
			gameObject.GetComponent<Image>().enabled = false;
			yield return new WaitForSeconds(blinkSpeed/2f);
			gameObject.GetComponent<Image>().enabled = true;
		}
	}

	IEnumerator BlinkLight() {
		while(true) {
			yield return new WaitForSeconds(blinkSpeed/3f);
			gameObject.GetComponent<Light>().enabled = false;
			yield return new WaitForSeconds(blinkSpeed/2f);
			gameObject.GetComponent<Light>().enabled = true;
		}
	}


}
