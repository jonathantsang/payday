using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControllerJob : MonoBehaviour {

	private Text cashText;
	private Text dateText;

	// Use this for initialization
	void Start () {
		cashText = GameObject.FindGameObjectWithTag ("cash").GetComponent<Text>();
		cashText.text = "Cash: $" + GameController.cash.ToString();
		dateText = GameObject.FindGameObjectWithTag ("date").GetComponent<Text> ();
		dateText.text = GameController.date.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
