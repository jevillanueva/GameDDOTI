using UnityEngine;
using System.Collections;

public class Back_all_level : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel(0);
		}
	}
}
