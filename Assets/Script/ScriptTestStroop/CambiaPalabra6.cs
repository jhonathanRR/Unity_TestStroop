using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;
//HAY QUE UTILIZAR ESTA LIBRERIA PARA CAMBIAR DE NIVEL
using UnityEngine.SceneManagement;

public class CambiaPalabra6 : MonoBehaviour {
	public float time=2;
	public Text UIText;

	// Use this forinitialization
	void Start () {		

	}

	// Update is called once per frame
	void Update () {

		time -= Time.deltaTime;

		UIText.text = time.ToString ("0");

		int tiempo = (int)time;
		Debug.Log (tiempo);

		if(tiempo==0)
		{
			SceneManager.LoadScene("Escena7");				
		}


		if(Input.GetMouseButton(0))
		{
			SceneManager.LoadScene ("Escena7");

		}
	}

}
