using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public static GameController instance;

	public static int date = 0;
	public static int cash = 100;

	// Use this for initialization
	void Start () {
		init ();

		// Set a random seed
		Random.InitState ((int)Mathf.Ceil(Random.Range(0,100)));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void init(){
		// Singleton Behaviour
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);    
		DontDestroyOnLoad(gameObject);
	}

	// Banner Text is handled exclusively in textController for the level
}
