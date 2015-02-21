using UnityEngine;
using System.Collections;

public class Corrupt_controller : MonoBehaviour {
	public bool is_dead=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Animator>().SetBool("morir",is_dead);
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			is_dead=true;
			Destroy(this.gameObject.GetComponent<PolygonCollider2D>());
			Destroy(this.gameObject.GetComponent<BoxCollider2D>());
			Destroy(this.gameObject,1.2f);
		}
	}
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Player") {

			//Debug.Log("Triger");
		}
	}
}
