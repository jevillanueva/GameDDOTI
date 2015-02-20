using UnityEngine;
using System.Collections;

public class Player_coin : MonoBehaviour {
	public int score_coin=0;
	// Use this for initialization
	void Start () {
		score_coin = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Moneda") {
			score_coin=score_coin+15;
		}
	}
	void OnGUI(){
		GUI.Label (new Rect (Screen.width / 1.5f, Screen.height / 3f, Screen.width / 5, Screen.height / 5), "Monedas: " + score_coin.ToString ());
	}
}
