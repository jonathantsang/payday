using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public static GameController instance;

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
		init ();

		// Find dataPrice object
		data = GameObject.FindGameObjectWithTag("data").GetComponent<currentPrice>();

		// Init text
		worthText = GameObject.FindGameObjectWithTag ("worth").GetComponent<Text>();
		worthText.text = "$ 200";
		priceText = GameObject.FindGameObjectWithTag ("price").GetComponent<Text>();
		priceText.text = "Price: $" + data.price;
		stockText = GameObject.FindGameObjectWithTag ("stock").GetComponent<Text>();
		stockText.text = "Stock: " + data.stock;
		cashText = GameObject.FindGameObjectWithTag ("cash").GetComponent<Text>();
		cashText.text = "Cash: $" + data.cash;

		// Set a random seed
		Random.InitState ((int)Mathf.Ceil(Random.Range(0,100)));
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

	void init(){
		// Singleton Behaviour
			if (instance == null)
				instance = this;
			else if (instance != this)
				Destroy(gameObject);    
			DontDestroyOnLoad(gameObject);
	}
}
