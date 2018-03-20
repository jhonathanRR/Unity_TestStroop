using UnityEngine;

//HAY QUE UTILIZAR ESTA LIBRERIA PARA CAMBIAR DE NIVEL
using UnityEngine.SceneManagement;

public class CambiaPalabra7 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		cambiaPalabra8 ();		
	}

	public void cambiaPalabra8(){
		if(Input.GetMouseButton(0))
		{
			SceneManager.LoadScene ("Escena8");

		}
	}



}