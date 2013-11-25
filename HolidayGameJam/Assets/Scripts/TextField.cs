using UnityEngine;
using System.Collections;

public class TextField : MonoBehaviour {

	public string InputString = "...";
	void OnGUI() {
		Vector3 screenPos = Camera.main.WorldToScreenPoint (transform.position);
		InputString = GUI.TextField(new Rect(screenPos.x,screenPos.y, 300, 40), InputString, 25);
	} 
}
