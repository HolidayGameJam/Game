﻿using UnityEngine;
using System.Collections;

public class BladeTestFunction : MonoBehaviour {

	public TextField Blade;
	private GameObject Bladepicture;
	private GameObject Andrewpicture;

	// Use this for initialization
	void Start () {
		Blade = GameObject.Find("GameObject").GetComponent<TextField>();
		Bladepicture = GameObject.Find ("New Sprite");
		Andrewpicture = GameObject.Find ("AndrewFace");
	}
	
	// Update is called once per frame
	void Update () {
		if (Blade.InputString == "type this line for Blade")
		{
			Vector3 tempvect = new Vector3(Bladepicture.transform.position.x, Bladepicture.transform.position.y, -1.0f);
			Bladepicture.transform.position = tempvect;

			tempvect = new Vector3(Andrewpicture.transform.position.x, Andrewpicture.transform.position.y, 1.0f);
			Andrewpicture.transform.position = tempvect;
			//Debug.Log("Hello Blade!");
		}
		else
		{
			Vector3 tempvect = new Vector3(Bladepicture.transform.position.x, Bladepicture.transform.position.y, -1.0f);
			Andrewpicture.transform.position = tempvect;
			
			tempvect = new Vector3(Andrewpicture.transform.position.x, Andrewpicture.transform.position.y, 1.0f);
			Bladepicture.transform.position = tempvect;
			//Debug.Log("Hello Andrew!");
		}
	}
}
