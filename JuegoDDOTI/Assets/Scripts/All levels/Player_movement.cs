using UnityEngine;
using System.Collections;

public class Player_movement : MonoBehaviour {
	public float velocidad_salto;
	public float velocidad_movimiento;
	public int cant_salto;
	bool sw_izq,sw_der,sw_salto;
	bool MirarDerecha =true;
	void Start () {
		sw_izq = false;
		sw_der = false;
		sw_salto = false;
		cant_salto = 0;
	}


	//invertir el personaje cuando vaya hacia atras
	void FixedUpdate(){
		float  h= Input.GetAxis ("Horizontal");
		if(h > 0 &&!MirarDerecha)
			Flip ();
		else if(h < 0 && MirarDerecha)
			Flip ();
	}
	
	void Flip () {
		MirarDerecha = !MirarDerecha;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void Update () {
		//Manejo del movimiento
		if (sw_izq) {
			transform.Translate(-velocidad_movimiento,0,0);
		}
		if (sw_der) {
			transform.Translate(velocidad_movimiento,0,0);
		}
		if (sw_salto && cant_salto <= 1) {
			this.rigidbody2D.AddForce(new Vector2(0,velocidad_salto));
		}


		if (Input.GetKeyDown (KeyCode.A)) {
			sw_izq=true;
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			sw_izq=false;
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			sw_der=true;
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			sw_der=false;
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			cant_salto++;
			sw_salto=true;
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			sw_salto=false;
		}



	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Piso") {
			cant_salto=0;
		}
	}

}
