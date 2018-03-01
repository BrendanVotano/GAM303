using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour {

	public GameObject[] waypoints;

	public List<GameObject> personList;
	// Use this for initialization

	void Start () {
		//waypoints [0].SetActive (false);
		//waypoints [1].GetComponent<Rigidbody> ().useGravity = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			foreach (GameObject go in personList) 
			{
				Debug.Log(go.GetComponent<Person> ().personName);
			}	
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			foreach (GameObject go in personList) 
			{
				if (go.GetComponent<Person> ().personAge >= 25)
					go.GetComponent<Renderer> ().material.color = Color.green;
			}	
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) 
		{
			foreach (GameObject go in personList) 
			{
				if (go.GetComponent<Person> ().personAge >= 25)
					personList.Remove (go.gameObject);
			}	
		}


		
	}
}
