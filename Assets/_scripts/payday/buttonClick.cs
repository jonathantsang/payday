using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour {

	string type;
	currentPrice cP;
	textControllerPayday tC;

	// Use this for initialization
	void Start () {
		cP = GameObject.FindGameObjectWithTag ("data").GetComponent<currentPrice> ();
		tC = GameObject.FindGameObjectWithTag ("textController").GetComponent<textControllerPayday> ();
		type = gameObject.transform.tag;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		if (type == "buy") {
			// Check if player has enough money
			if (cP.price <= cP.cash) {
				// Subtract cash
				cP.cash -= cP.price;
				// Increase stock
				cP.stock += 1;
				cP.updateWorth ();
				tC.updateAmounts ();
			}
		} else if (type == "sell") {
			// Check if enough
			if (cP.stock > 0) {
				// Add cash
				cP.cash += cP.price;
				// Subtract stock
				cP.stock -= 1;
				cP.updateWorth ();
				tC.updateAmounts ();
			}
		}
	}
}
