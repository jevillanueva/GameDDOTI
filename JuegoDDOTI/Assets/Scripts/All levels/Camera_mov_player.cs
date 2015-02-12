using UnityEngine;
using System.Collections;

public class Camera_mov_player : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y/4, -10);
	}
}
