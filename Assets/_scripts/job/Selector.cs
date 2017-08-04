using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("run");
		updatePosition ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updatePosition(){
		// Move the selector to the first element of the gridManagement
		transform.position = GameObject.FindGameObjectWithTag("grid").GetComponent<gridManagement>().getCurrentCellTransform().position;
	}
}
