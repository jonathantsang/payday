using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridManagement : MonoBehaviour {

	// Corresponds to index of child cell that is the current one
	public int currentCell;

	// Colours
	public Sprite green;
	public Sprite red;

	// Use this for initialization
	void Start () {
		currentCell = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Transform getCurrentCellTransform(){
		if (currentCell < transform.childCount) {
			return transform.GetChild (currentCell).transform;
		} else {
			return transform;
		}
	}

	public void next(){
		if (currentCell < transform.childCount) {
			currentCell++;
			// Update the selector
			GameObject.FindGameObjectWithTag("selector").GetComponent<Selector>().updatePosition();
		}
	}

	public void verify(string direction){
		// If the direction given is correct, put a green, else put red
		if (direction == transform.GetChild (currentCell).GetComponent<Cell> ().type) {
			// Change the result, the child of the cell object to red or green
			transform.GetChild (currentCell).GetChild (0).GetComponent<SpriteRenderer> ().sprite = green;
		} else {
			transform.GetChild (currentCell).GetChild (0).GetComponent<SpriteRenderer> ().sprite = red;
		}
	}
}
