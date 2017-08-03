using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour {

	string type;
	currentPrice cP;
	GameController GC;

	// Use this for initialization
	void Start () {
		cP = GameObject.FindGameObjectWithTag ("data").GetComponent<currentPrice> ();
		GC = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
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
				GC.updateAmounts ();
			}
		} else if (type == "sell") {
			// Check if enough
			if (cP.stock > 0) {
				// Add cash
				cP.cash += cP.price;
				// Subtract stock
				cP.stock -= 1;
				GC.updateAmounts ();
			}
		}
	}
}
