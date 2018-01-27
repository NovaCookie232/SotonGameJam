using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementBehaviour : MonoBehaviour {

	float speed;
	GameObject key;
	// Use this for initialization
	void Start () {
		speed = 2.0f;
		key = GameObject.Find("Key");
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject == key) 
		{
			keyBehaviour keyScript = key.GetComponent<keyBehaviour> ();
			keyScript.collected = true;
			key = null;
		}
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) 
		{
			Vector3 mov = (Time.deltaTime * transform.forward) * speed;
			transform.Translate (mov);
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			Vector3 mov = (Time.deltaTime * transform.forward) * speed;
			transform.Translate (-mov);
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			Vector3 mov = (Time.deltaTime * transform.right) * speed;
			transform.Translate (-mov);
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			Vector3 mov = (Time.deltaTime * transform.right) * speed;
			transform.Translate (mov);
		}

	}
}
