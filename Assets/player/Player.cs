﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public UnityEngine.UI.Text text;

	private int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Coin"){
			this.score += other.GetComponent<Coin> ().getValue ();
			this.text.text = "Score: " + this.score;
			Destroy (other.gameObject);
		}
	}

}
