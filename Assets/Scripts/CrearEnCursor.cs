using UnityEngine;
using System.Collections;



// Crea un prefab en la posicion del cursor al hacer click

public class CrearEnCursor : MonoBehaviour {

	// Use this for initialization

	public Transform objetoAColocar;
	private Ray ray;

	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {


		bool shoot = Input.GetButtonDown("Fire1");

		if (shoot) {

			var shotTransform = Instantiate(objetoAColocar) as Transform;


			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition );
			mousePos.z = 0;
	
			shotTransform.position= mousePos;



		}
	
	}
}
