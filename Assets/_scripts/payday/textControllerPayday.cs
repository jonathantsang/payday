using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControllerPayday: MonoBehaviour {

	// The text components of the game
	private Text worthText;
	private Text priceText;
	private Text stockText;
	private Text cashText;

	private currentPrice data;

	private float timeCounter = 0;
	private float timeLimit = 2f;

	// Use this for initialization
	void Start () {
		// Find dataPrice object
		data = GameObject.FindGameObjectWithTag("data").GetComponent<currentPrice>();

		// Date should not be changed, and it is set once
		GameController GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		if (GC) {	
			Text dateText = GameObject.FindGameObjectWithTag ("date").GetComponent<Text> ();
			dateText.text = GameController.date.ToString ();
		}

		// Init text
		cashText = GameObject.FindGameObjectWithTag ("cash").GetComponent<Text>();
		cashText.text = "Cash: $" + data.cash;
		worthText = GameObject.FindGameObjectWithTag ("worth").GetComponent<Text>();
		worthText.text = "$ " + data.cash;
		priceText = GameObject.FindGameObjectWithTag ("price").GetComponent<Text>();
		priceText.text = "Price: $" + data.price;
		stockText = GameObject.FindGameObjectWithTag ("stock").GetComponent<Text>();
		stockText.text = "Stock: " + data.stock;


	}
	
	// Update is called once per frame
	void Update () {
		// Update the price
		if (timeCounter > timeLimit) {
			updateAmounts ();
			data.updateWorth ();
			timeCounter = 0;
		}
		timeCounter += Time.deltaTime;
	}

	public void updateAmounts(){
		priceText.text = "Price: $" + data.price;
		worthText.text = "$0";
		stockText.text = "Stock: " + data.stock;
		cashText.text = "Cash: $" + data.cash;
		worthText.text = "$ " + data.worth;
	}
}
