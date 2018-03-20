using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//HAY QUE UTILIZAR ESTA LIBRERIA PARA CAMBIAR DE NIVEL
using UnityEngine.SceneManagement;

public class CambiaPalabra1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		cambiaPalabra2 ();		
	}

	public void cambiaPalabra2(){
		if(Input.GetMouseButton(0))
		{
			SceneManager.LoadScene ("Escena2");
			
		}
	}



}
