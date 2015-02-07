using UnityEngine;
using System.Collections;

public class Rate_star : MonoBehaviour {
	float w,h;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		w = Screen.width;
		h = Screen.height;
	}
	void OnGUI(){
		if(GUI.Button(new Rect(w/13,h/2,w/6,h/10),"Una estrella")){
			PlayerPrefs.SetInt("star"+Application.loadedLevel,1);
		}
		if(GUI.Button(new Rect(w/3.5f,h/2,w/6,h/10),"Dos estrellas")){
			PlayerPrefs.SetInt("star"+Application.loadedLevel,2);
		}
		if(GUI.Button(new Rect(w/2f,h/2,w/6,h/10),"Tres estrellas")){
			PlayerPrefs.SetInt("star"+Application.loadedLevel,3);
		}
		PlayerPrefs.Save ();
	}
}
