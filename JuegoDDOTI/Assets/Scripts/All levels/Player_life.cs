using UnityEngine;
using System.Collections;

public class Player_life : MonoBehaviour {
	float w,h;
	public int vida=3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		w = Screen.width;
		h = Screen.height;
	}
	void OnGUI(){
		GUI.Label (new Rect (w / 4, h / 4, w / 6, h / 10), ("vidas: " + vida.ToString ()));
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Enemigo") {
			vida++;
		}
	}
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Enemigo") {
			vida--;
		}
	}
}
