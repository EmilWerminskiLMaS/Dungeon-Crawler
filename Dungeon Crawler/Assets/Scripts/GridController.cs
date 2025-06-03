using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridController : MonoBehaviour {

	private Grid grid;
	[SerializeField] private Tilemap interaction;
	[SerializeField] private Tile hoverTile;

	private Vector3Int previousTilePosition = new Vector3Int ();

	// Use this for initialization
	void Start () {
		grid = gameObject.GetComponent<Grid> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector3Int tilePosition = grid.WorldToCell (mousePosition);

		if (Input.GetMouseButtonDown(0)) {
			interaction.SetTile (previousTilePosition, null);
			interaction.SetTile (tilePosition, hoverTile);
			previousTilePosition = tilePosition;
		}

		Debug.DrawLine (GameObject.FindWithTag ("Player").transform.position, new Vector3 (previousTilePosition.x + 0.5f, previousTilePosition.y + 0.5f), Color.red);
	}
}