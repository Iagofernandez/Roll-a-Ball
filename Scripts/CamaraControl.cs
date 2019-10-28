using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour {
 public GameObject Bola;
 private Vector3 offset;
	// Use this for initialization

	//Le estamos indicando que para obtener el valor de offset 
	//Tome la posicion de la camara y le reste la posicion del jugador
	void Start () {
		offset = transform.position - Bola.transform.position;
	}
	
	// LateUpdate es llamado una vez por farmae
	//Pero garantiza que va a ejecutarse despues de que todos los items
	//Han sido procesados en Update
	void LateUpdate () {
		//Este codigo indica que antes de mostrar lo que saldra por pantalla
		//la camara se movera primero a la nueva posicion
		transform.position = Bola.transform.position + offset;

	}
}
