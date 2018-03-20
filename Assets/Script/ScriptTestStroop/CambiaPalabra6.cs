using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//HAY QUE UTILIZAR ESTA LIBRERIA PARA CAMBIAR DE NIVEL
using UnityEngine.SceneManagement;

public class CambiaPalabra6 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		cambiaPalabra7 ();		
	}

	public void cambiaPalabra7(){
		if(Input.GetMouseButton(0))
		{
			SceneManager.LoadScene ("Escena7");

		}
	}



}
