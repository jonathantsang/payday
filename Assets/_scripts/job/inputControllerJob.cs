using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputControllerJob : MonoBehaviour {

	gridManagement gM;

	// Use this for initialization
	void Start () {
		gM = GameObject.FindGameObjectWithTag ("grid").GetComponent<gridManagement> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Check for up arrow
		if (Input.GetKeyDown ("w") || Input.GetKeyDown (KeyCode.UpArrow)) {
			gM.verify ("up");
			gM.next ();
		} else if (Input.GetKeyDown ("s") || Input.GetKeyDown (KeyCode.DownArrow)) {
			gM.verify ("down");
			gM.next ();
		} else if (Input.GetKeyDown ("a") || Input.GetKeyDown (KeyCode.LeftArrow)) {
			gM.verify ("left");
			gM.next ();
		} else if (Input.GetKeyDown ("d") || Input.GetKeyDown (KeyCode.RightArrow)) {
			gM.verify ("right");
			gM.next ();
		}			
	}
}
