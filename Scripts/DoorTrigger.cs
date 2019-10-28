using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {
	[SerializeField]
	//Este script permite que al pisar las baldosas del suelo
	//levante la puerta 
GameObject Puerta;
 
	// Use this for initialization
	
		
	
public void OnTriggerEnter (Collider col){
	
	Puerta.transform.position += new Vector3(0,4,0);
	


}
	// Use this for initialization
}
