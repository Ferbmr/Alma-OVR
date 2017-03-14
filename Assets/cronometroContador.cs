using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Para poder utilizar el UI.TEXT debemos declarar esta libreria!

public class cronometroContador : MonoBehaviour {

	public float counter = 0; //Aqui creacos un contador y lo inicializamos en "0"

	public Text TextoContador; //Aqui declaramos un texto con el nombre TextoContador


	// Use this for initialization
	void Start () {
		TextoContador = GetComponent<Text> (); //Al texto que hemos declarado arriba como TextoContador, le asignamos el componente GetComponent<Text> (Este componente es el UI.TEXT)
		TextoContador.text = "" + counter; //Ahora al TextoContador le decimos que escriba dentro de las "" el valor de counter.
		//(Y como a TextoContador le hemos añadido el componente "GetComponent<Text>" pues el UI.TEXT que tenemos en nuestro juego mostrara dicho valor.

	}

	// Update is called once per frame
	void Update ()
	{
		counter += Time.deltaTime;
		if (counter < 100) //Aqui creamos un IF que compruebe que counter sea menor a 100
		{  
			TextoContador.text = "" + counter.ToString("0.##"); //Aqui tambien debemos poner este codigo para cuando el contador sume +1, nuestro UI.TEXT actualize el numero al actual.
		}
		else //Luego creamos un else if y comprobamos si el valor de counter a llegao a 100
		{  
			TextoContador.text = "¡GANASTE!";
		}

	}
}

