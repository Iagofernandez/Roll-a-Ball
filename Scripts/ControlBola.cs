using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlBola : MonoBehaviour {

public float velocidad;
private Rigidbody rb;
private int cuenta;

private Collider Enemy;
public Text Victoria;
public Text TextoCuenta;


/// Start is called on the frame when a script is enabled just before
/// any of the Update methods is called the first time.
/// </summary>
void Start()
{
	//El componente rigybody nos permite añadirle fisicas a nuestro 
	//gameObject jugador(chocar contra paredes, recolectar pickups, etc)
	rb = GetComponent<Rigidbody>();
	cuenta = 0;
	setCuentaTexto ();
	
	Victoria.text="";
}
//Esta part del codigo FIXEDUPDATE se llama antes de realizar
//cualquier cálculo de física
void FixedUpdate() {
	//Este Input.GetAxis recoge el input de nuestro jugador a traves del teclado
	float movimientoHorizontal = Input.GetAxis("Horizontal");
	float movimientoVertical = Input.GetAxis("Vertical");

    //nos permite mover a nuestro juagdor tanto en el eje x como en el z
	Vector3 movimiento = new Vector3(movimientoHorizontal ,0.0f , movimientoVertical);
    //Esto añade fuerzas a nuestro RIGIBODY,  lo que permite qe se mueva por el escenario
	//El multiplicarlo por la variable velocidad nos permite modificar la velocidad del jugador
	//desde Unity
	rb.AddForce(movimiento * velocidad);
}
	//aqui entra en funcion el collider o sistema de colisiones
	
 void OnTriggerEnter(Collider other) 
 {
	 //Si el objeto que tocas tiene el tag PickUp
	 //los "recoge"(los hace desaparecer)
	 //y se suma a la variable cuenta
	if (other.gameObject.CompareTag("PickUp"))
	{
		other.gameObject.SetActive(false);
		cuenta = cuenta + 1;
		setCuentaTexto();
		
		}
	//Al recoger los 10 pickup
	//tienes la opcion de atrapar a el enemigo 
	if(other.gameObject.CompareTag("Enemy")&&cuenta>=10){
			other.gameObject.SetActive(false);
	}
	if (other.gameObject.CompareTag("Enemy")){

	}

	
}
	
	
	
	
	void setCuentaTexto()
	{
		TextoCuenta.text = "Cuenta power cubes " +cuenta.ToString();
		
		if(cuenta >=10 ){
			Victoria.text="Victoria a cazar al enemigo";
			
		}
		
	}
}