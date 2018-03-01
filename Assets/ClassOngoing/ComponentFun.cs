using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentFun : MonoBehaviour {

	public float forceValue = 20;
	// Use this for initialization
	public Rigidbody theRigidbody; 

	void Start () 
	{
		theRigidbody = GetComponent<Rigidbody>();
		theRigidbody.useGravity = true;
		//GetComponent<SphereCollider> ().isTrigger = true;
		GetComponent<Renderer> ().material.color = Color.red;
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Debug.Log ("SPACE");
			theRigidbody.AddForce (0, forceValue, 0);
			GetComponent<Renderer> ().material.color = Color.green;
		}
	}

}
