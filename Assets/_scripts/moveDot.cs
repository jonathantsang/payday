using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDot : MonoBehaviour {

	private Rigidbody2D rb2d;
	private currentPrice priceObj;

	private float timeCounter = 0;
	private float timeLimit = 1.25f;

	// Use this for initialization
	void Start () {
		rb2d = GameObject.FindGameObjectWithTag("dot").GetComponent<Rigidbody2D>();
		priceObj = GameObject.FindGameObjectWithTag ("price").GetComponent<currentPrice> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (timeCounter > timeLimit) {
			rb2d.AddForce (new Vector2 (0,(priceObj.price-priceObj.previousPrice)*2));
			timeCounter = 0;
		}
		timeCounter += Time.deltaTime;

	}
}
