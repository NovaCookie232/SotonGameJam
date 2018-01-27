using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyBehaviour : MonoBehaviour {

	public bool collected;
	// Use this for initialization
	void Start () {
		collected = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (collected)
		{
			Destroy (gameObject);
		}
	}
}
