using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movements : MonoBehaviour {
 public Transform Bola;
    NavMeshAgent Enemy;
    
	
	public float min;
    
	
	Animator animator;
    
	// Use this for initialization
	void Start () {
		Enemy = GetComponent<NavMeshAgent>();
		Enemy.autoBraking = false;
		animator = Bola.GetComponent<Animator>();
		
		
	}
	
	// Update is called once per frame
	void Update () {

		Enemy.SetDestination(Bola.position);
        //Este codigo sirve para indicar cuando la bola esta a salvo
		//Y cuando esta en peligro
		//Si la distancia entre la bola y el enemigo es inferior a la minima
		//(Se puede alterar esta distancia en el propio Unity)
		//la bola esta en peligro
		if(!Enemy.pathPending && Enemy.remainingDistance < min)
		{
			Debug.Log("Peligro");

			animator.SetBool("EstarEnPeligro", false);
		}
		else
		{
			{
				Debug.Log("Tranquilo");
				animator.SetBool("EstarEnPeligro", true);
			}
		}
	
}


}

