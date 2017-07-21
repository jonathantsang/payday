using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour {

	private Text moneyShown;
	private Text priceText;
	private currentPrice priceObj;
	private float price = 30;

	private float timeCounter = 0;
	private float timeLimit = 1.25f;

	// Use this for initialization
	void Start () {
		// Init text
		moneyShown = GameObject.FindGameObjectWithTag ("moneyShown").GetComponent<Text>();
		moneyShown.text = "$0";
		priceText = GameObject.FindGameObjectWithTag ("price").GetComponent<Text>();
		priceText.text = "$" + price;
		priceObj = GameObject.FindGameObjectWithTag ("price").GetComponent<currentPrice> ();
		priceObj.price = 30;

		// Set a random seed
		Random.InitState ((int)Mathf.Ceil(Random.Range(0,100)));
	}
	
	// Update is called once per frame
	void Update () {
		if (timeCounter > timeLimit) {
			price = Random.Range (price - 5, price + 5);
			priceText.text = "$" + price;
			priceObj.previousPrice = priceObj.price;
			priceObj.price = price;
			timeCounter = 0;
		}
		timeCounter += Time.deltaTime;
	}
}
