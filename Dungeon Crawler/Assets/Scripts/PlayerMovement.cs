using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour {

	public Tilemap tilemap;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = new Vector3 ();

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			newPosition = Vector3.up;
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			newPosition = Vector3.down;
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			newPosition = Vector3.right;
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			newPosition = Vector3.left;
		}


		if (tilemap.GetTile(tilemap.WorldToCell(transform.position + Vector3Int.FloorToInt(newPosition))) != null) {
			transform.position += newPosition;
		}

	}
}
