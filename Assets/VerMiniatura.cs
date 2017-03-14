using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class VerMiniatura : MonoBehaviour {
	public float distancia;
	//public Image Panel;
	//public Text TextoTitulo;
	//public Text TextoDetalle;
	public GameObject ObjMin1;
	public GameObject ObjMin2;
	public GameObject ObjMin3;
	public GameObject ObjMin4;
	public GameObject Linterna;
	public GameObject Objeto;
	public GameObject Objeto2;
	public GameObject Objeto3;
	public GameObject Objeto4;
	public GameObject Muñeca;
	public GameObject collider1;
	public GameObject collider2;
	public GameObject collider3;
	public GameObject collider4;
	public GameObject collider5;
	public GameObject collider6;
	public GameObject collider7;
	public GameObject collider8;
	public GameObject collider9;
	public GameObject collider10;
	public GameObject collider11;
	public Vector3 P = new Vector3 (0, 0, 0);
	public Vector3 D = new Vector3 (0, 0, 0);
	public int Notas;

	public GameObject puerta;
	public GameObject puerta2;
	public GameObject puerta3;
	Animator animPuerta;
	Animator animPuerta2;
	Animator animPuerta3;

	bool candado = false;
	bool candado2 = false;
	bool candado3 = false;


	public AudioSource sonidoDoll;
	public AudioSource sonido1;
	public AudioSource sonido2;
	public AudioSource sonido3;
	public AudioSource sonido4;
	public AudioSource sonido5;
	public AudioSource sonido6;
	public AudioSource sonido7;
	public AudioSource sonido8;
	public AudioSource sonido9;
	public AudioSource sonido10;





	void Start () {
		//Panel.enabled = false;
		//TextoTitulo.enabled = false;
		//TextoDetalle.enabled = false;

		ObjMin1.SetActive (false);
		ObjMin2.SetActive (false);
		ObjMin3.SetActive (false);
		ObjMin4.SetActive (false);
		Objeto.SetActive (true);
		Objeto2.SetActive (false);
		Objeto3.SetActive (false);
		Objeto4.SetActive (true);
		collider11.SetActive (false);
		animPuerta = puerta.GetComponent<Animator> ();
		animPuerta2 = puerta.GetComponent<Animator> ();
		animPuerta3 = puerta.GetComponent<Animator> ();

		//TextoTitulo = GetComponent<Text> ();
		//TextoDetalle = GetComponent<Text> ();	
	}

	void Update () {

		RaycastHit R;
		Debug.DrawRay (this.transform.position, this.transform.forward, Color.cyan, distancia);

		P = transform.parent.position;
		D = transform.TransformDirection (Vector3.forward);
//****************************************************************************************************
		//ACTIVAR BOTÓN
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "Objeto1") {
			//	Panel.enabled = true;
			//	TextoTitulo.enabled = true;
			//	TextoDetalle.enabled = true;
				Notas = Notas + 1;
				ObjMin1.SetActive (true);
				candado = true;


			//	TextoTitulo.text = ("Libro").ToString ();
			//	TextoDetalle.text = ("Éste libro..... blah blah blah... ").ToString ();
			} else if (R.collider.tag != "Objeto1" || R.collider.tag == null){
			//	Panel.enabled = false;
			//	TextoTitulo.enabled = false;
			//	TextoDetalle.enabled = false;

				ObjMin1.SetActive (false);
			}
		}
		//DESACTIVAR
		if (Input.GetMouseButtonDown (0)) {
			//Panel.enabled = false;
			//TextoTitulo.enabled = false;
			//TextoDetalle.enabled = false;

			ObjMin1.SetActive(false);
		}

		if (Notas == 2) {
			animPuerta.SetBool ("abierto", true);
		}

//****************************************************************************************************************

		//ACTIVAR BOTÓN
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "Objeto2") {
				//Panel.enabled = true;
				//TextoTitulo.enabled = true;
				//TextoDetalle.enabled = true;
				Notas = Notas + 1;
				ObjMin2.SetActive (true);
				candado2 = true;


				//TextoTitulo.text = ("Libro").ToString ();
				//TextoDetalle.text = ("Éste libro..... blah blah blah... ").ToString ();
			} else if (R.collider.tag != "Objeto2" || R.collider.tag == null){
				//Panel.enabled = false;
				//TextoTitulo.enabled = false;
				//TextoDetalle.enabled = false;

				ObjMin2.SetActive (false);
			}
		}
		//DESACTIVAR
		if (Input.GetMouseButtonDown (0)) {
			//Panel.enabled = false;
			//TextoTitulo.enabled = false;
			//TextoDetalle.enabled = false;

			ObjMin2.SetActive(false);
		}

		if (Notas == 2) {
			animPuerta2.SetBool ("abierto", true);
		}


//****************************************************************************************************************

		//ACTIVAR BOTÓN
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "Objeto3") {
				//Panel.enabled = true;
				//TextoTitulo.enabled = true;
				//TextoDetalle.enabled = true;
				Notas = Notas + 1;
				ObjMin3.SetActive (true);
				candado3 = true;


				//TextoTitulo.text = ("Libro").ToString ();
				//TextoDetalle.text = ("Éste libro..... blah blah blah... ").ToString ();
			} else if (R.collider.tag != "Objeto3" || R.collider.tag == null){
				//Panel.enabled = false;
				//TextoTitulo.enabled = false;
				//TextoDetalle.enabled = false;

				ObjMin3.SetActive (false);
			}
		}
		//DESACTIVAR
		if (Input.GetMouseButtonDown (0)) {
			//Panel.enabled = false;
			//TextoTitulo.enabled = false;
			//TextoDetalle.enabled = false;

			ObjMin3.SetActive(false);
		}

		if (Notas == 2) {
			animPuerta3.SetBool ("abierto", true);
		}


//******************************************************************************************


		//ACTIVAR BOTÓN
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "Objeto4") {

				ObjMin4.SetActive (true);
				sonidoDoll.Play (); 
				Destroy (Muñeca, 3);
				Destroy (Objeto4, 5);

			}
		}

		if (Muñeca == null){
				
				SceneManager.LoadScene ("menu");
				ObjMin4.SetActive (false);

			
		}
		//DESACTIVAR


//****************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "colliderTrigger") {
				//	Panel.enabled = true;
				//	TextoTitulo.enabled = true;
				//	TextoDetalle.enabled = true;
				Notas = Notas + 1;
				Objeto.SetActive (false);
				candado = true;
				sonido2.Play ();
				Destroy(collider1, 0.5f);


				//	TextoTitulo.text = ("Libro").ToString ();
				//	TextoDetalle.text = ("Éste libro..... blah blah blah... ").ToString ();
			}
		}


		//****************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "colliderAudio1") {
				//	Panel.enabled = true;
				//	TextoTitulo.enabled = true;
				//	TextoDetalle.enabled = true;
				sonido1.Play();
				Destroy (collider2, 0.1f);
				//Destroy(colli = "colliderAudio1");


				//	TextoTitulo.text = ("Libro").ToString ();
				//	TextoDetalle.text = ("Éste libro..... blah blah blah... ").ToString ();
			}
		}

		//***********************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "collider3") {
				
				sonido3.Play();
				Destroy (collider3, 1);

			}
		}

		//***********************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "collider4") {

				sonido4.Play();
				Destroy (collider4, 1);

			}
		}


		//***********************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "collider5") {

				sonido5.PlayDelayed (3);


				Destroy (collider5, 1);

			}
		}

		//***********************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "collider6") {

				sonido6.PlayDelayed (1);
				sonido3.Stop ();

				Destroy (collider6, 1);

			}
		}
		//***********************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "collider7") {


				sonido1.Stop ();

				Destroy (collider7, 1);

			}
		}
		//***********************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "collider8") {


				sonido7.Play ();
				sonido8.PlayDelayed (1);

				Destroy (collider8, 0.1f);

			}
		}
		//***********************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "collider9") {

				Objeto2.SetActive (true);
				sonido9.Play ();
				Destroy (collider9, 0.1f);
				Destroy (Objeto2, 1.5f);
				Destroy (Objeto4);
			}
		}

		//***********************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "collider10") {


				sonido10.Play ();
				Objeto3.SetActive(true);
				Destroy (collider10, 0.1f);
				Linterna.SetActive (false);
				collider11.SetActive (true);
			}
		}
		//***********************************************************************************
		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "collider11") {

				Destroy (collider11, 0.1f);
				Destroy (Objeto3);
				Linterna.SetActive (true);
			}
		}
	} 
}
