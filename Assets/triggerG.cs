using UnityEngine;
using System.Collections;

public class triggerG : MonoBehaviour {
	public float distancia;
	public GameObject Objeto;
	public Vector3 P = new Vector3 (0,0,0);
	public Vector3 D = new Vector3 (0,0,0); 




	// Use this for initialization
	void Start () {
		Objeto.SetActive(true);
	
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit R;
		Debug.DrawRay (this.transform.position, this.transform.forward, Color.cyan, distancia);
		P = transform.parent.position;
		D = transform.TransformDirection (Vector3.forward);

		if (Physics.Raycast (P, D, out R, distancia)) {
			if (R.collider.tag == "colliderG") {
				//	Panel.enabled = true;
				//	TextoTitulo.enabled = true;
				//	TextoDetalle.enabled = true;

				Objeto.SetActive (false);

			}
		}
	}
}
