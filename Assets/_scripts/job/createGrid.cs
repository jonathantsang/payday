using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createGrid : MonoBehaviour {

	public Sprite left;
	public Sprite right;
	public Sprite up;
	public Sprite down;

	// Going from 0 to 77 is 78 cells or 11 * 7
	private float startX = -5.5f;
	private float startY = -4f;
	public GameObject cell;


	private List<Sprite> sprites = new List<Sprite>();

	// Use this for initialization
	void Start () {
		sprites.Add (left);
		sprites.Add (right);
		sprites.Add (up);
		sprites.Add (down);

		// Counts up to 77 objects
		int total = 0;
		// Initialize the grid and set a random arrow for each cell
		for(int i = 0; i < 8; i++){
			for (int j = 0; j < 12; j++) {
				GameObject newCell = Instantiate (cell, new Vector2 (startX + j, startY + i), Quaternion.identity) as GameObject;
				print ("created");
				newCell.transform.parent = transform;

				int index = ((int)Random.Range (1, 100)) % sprites.Count;
				transform.GetChild (total).GetComponent<SpriteRenderer> ().sprite = sprites [index];
				if (index == 0) {
					transform.GetChild (total).GetComponent<Cell> ().type = "left";
				} else if (index == 1) {
					transform.GetChild (total).GetComponent<Cell> ().type = "right";
				} else if (index == 2) {
					transform.GetChild (total).GetComponent<Cell> ().type = "up";
				} else if (index == 3) {
					transform.GetChild (total).GetComponent<Cell> ().type = "down";
				}
				total++;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
