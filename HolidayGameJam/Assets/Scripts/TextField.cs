using UnityEngine;
using System.Collections;

public class TextField : MonoBehaviour {

	public string InputString = "";
	public string textStore;

	public int InputStringSize;

	void OnGUI() {
		Vector3 screenPos = Camera.main.WorldToScreenPoint (transform.position);
		InputString = GUI.TextField(new Rect(screenPos.x,screenPos.y, 300, 40), InputString, 25);

		InputStringSize = InputString.Length;
		AssignTextStore();
	} 

	void Update () {
		if (InputString.Length >= InputStringSize && InputString.Length > 0)
		{	
			for (int i = 0; i < InputString.Length; i++)
			{
				//Debug.Log("Current letter of InputString is " + InputString[i]);
				if (textStore[i] != InputString[i])
				{
					InputString = InputString.Substring(0, i);
				}
			}
			InputStringSize = InputString.Length;
		}
	}

    void AssignTextStore() {
		textStore = GameObject.Find("GUI Text").GetComponent<GUIText>().text;
	}
}
