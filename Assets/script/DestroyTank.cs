﻿using UnityEngine;
using System.Collections;

public class DestroyTank : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTrigger2DEnter(Collision2D coli){
		Debug.Log ("aya");
		if (coli.gameObject.tag == "Enemy") {
			Debug.Log("hihi");
			Destroy(coli.gameObject);
		}
	}
}
