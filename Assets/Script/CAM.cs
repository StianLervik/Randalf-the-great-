using UnityEngine;
using System.Collections;

public class CAM : MonoBehaviour {
	
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Randalf");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.transform.position.x, player.transform.position.y + 2, player.transform.position.z - 8);
	}
}
