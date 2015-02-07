using UnityEngine;
using System.Collections;

public class Main_menu : MonoBehaviour {
	public bool sw_inicio;
	float w,h;
	public Texture zero_s;
	public Texture one_s;
	public Texture two_s;
	public Texture three_s;
	public GUISkin skin_star;
	Texture lev1;
	Texture lev2;
	Texture lev3;
	Texture lev4;
	// Use this for initialization
	void Start () {
		sw_inicio = false;

	}
	
	// Update is called once per frame
	void Update () {
		w = Screen.width;
		h = Screen.height;

		switch(PlayerPrefs.GetInt("star1")){
		case 1:
			lev1 = one_s;
			break;
		case 2:
			lev1 = two_s;
			break;
		case 3:
			lev1 = three_s;
			break;
		case 0:
			lev1 = zero_s;
			break;
		}

		switch(PlayerPrefs.GetInt("star2")){
		case 1:
			lev2 = one_s;
			break;
		case 2:
			lev2 = two_s;
			break;
		case 3:
			lev2 = three_s;
			break;
		case 0:
			lev2 = zero_s;
			break;
		}

		switch(PlayerPrefs.GetInt("star3")){
		case 1:
			lev3 = one_s;
			break;
		case 2:
			lev3 = two_s;
			break;
		case 3:
			lev3 = three_s;
			break;
		case 0:
			lev3 = zero_s;
			break;
		}

		switch(PlayerPrefs.GetInt("star4")){
		case 1:
			lev4 = one_s;
			break;
		case 2:
			lev4 = two_s;
			break;
		case 3:
			lev4 = three_s;
			break;
		case 0:
			lev4 = zero_s;
			break;
		}


	}
	void OnGUI(){
		GUI.skin = skin_star;
		if (sw_inicio) {

			if(GUI.Button(new Rect(w/1.5f,h/5,w/10,h/10),"X")){
				sw_inicio=false;
			}

			if(GUI.Button(new Rect(w/13,h/2,w/6,h/10),"Nivel 1")){
				Application.LoadLevel(1);
			}
			GUI.Box(new Rect(w/13,h/1.8f,w/6,h/10),lev1);

			if(GUI.Button(new Rect(w/3.5f,h/2,w/6,h/10),"Nivel 2")){
				Application.LoadLevel(2);
			}
			GUI.Box(new Rect(w/3.5f,h/1.8f,w/6,h/10),lev2);

			if(GUI.Button(new Rect(w/2f,h/2,w/6,h/10),"Nivel 3")){
				Application.LoadLevel(3);
			}
			GUI.Box(new Rect(w/2f,h/1.8f,w/6,h/10),lev3);

			if(GUI.Button(new Rect(w/1.4f,h/2,w/6,h/10),"Nivel 4")){
				Application.LoadLevel(4);
			}
			GUI.Box(new Rect(w/1.4f,h/1.8f,w/6,h/10),lev4);

		}else{
			if(GUI.Button(new Rect(w/2.1f,h/2,w/10,h/10),"START")){
				sw_inicio=true;
			}
		}
	}
}
