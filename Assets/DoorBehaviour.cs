﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour {

	bool dooropen;
	GameObject key;
	GameObject player;
	Vector3 startingPos;
	float movUp;

	// Use this for initialization
	void Start () {
		dooropen = false;
		startingPos = transform.position;
		key = GameObject.Find ("Key");
		player = GameObject.Find ("Player");

	}

	// Update is called once per frame
	void Update () {
		if (key == null) {
			dooropen = true;
		}
		if (transform.position.y > startingPos.y + 1.0f) 
		{
			dooropen = false;
		}
		if (dooropen == true) 
		{
			movUp = Time.deltaTime * 0.5f;
			Vector3 move = new Vector3(0, movUp, 0);
			transform.Translate (move);
		}
	}
}
