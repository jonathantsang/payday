using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {

	public float x;
	public float y;
	public string type;
	public bool correct;

	// Use this for initialization
	void Start () {
		x = gameObject.transform.position.x;
		y = gameObject.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
