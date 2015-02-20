using UnityEngine;
using System.Collections;

public class Moneda_script : MonoBehaviour {
	public float girar_x=0;
	public float girar_y=0;
	public float girar_z=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (girar_x, girar_y, girar_z);
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			Destroy(this.gameObject);
		}
	}
}

