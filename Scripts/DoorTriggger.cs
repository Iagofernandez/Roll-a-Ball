using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggger : MonoBehaviour {
[SerializeField]
//Este script permite que al pisar la baldosa
//La posicion de la peurta se modifique y baje
	// Use this for initialization
	GameObject Puerta;
 
	// Use this for initialization
	
		
	
public void OnTriggerEnter (Collider col){
	
	Puerta.transform.position += new Vector3(0,-4,0);
	


}
}
