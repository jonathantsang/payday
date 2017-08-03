using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentPrice : MonoBehaviour {

	[HideInInspector]
	public float previousPrice = 30;
	[HideInInspector]
	public float price = 30;
	[HideInInspector]
	public float stock = 0;
	[HideInInspector]
	public float cash = 200;

	private float timeCounter = 0;
	private float timeLimit = 3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Update the price
		if (timeCounter > timeLimit) {
			price = Random.Range (price - 5, price + 5);
			timeCounter = 0;
			print (price);
		}
		timeCounter += Time.deltaTime;
	}
}
