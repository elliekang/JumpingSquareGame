﻿using UnityEngine;
using System.Collections;

public class CompleteBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.name == ("Player")) {
			Application.LoadLevel ("missionComplete");
		}
		
	}
}