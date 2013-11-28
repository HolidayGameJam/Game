using UnityEngine;
using System.Collections;

public class TextFieldChecker : MonoBehaviour {

	public TextField getProgressField;
	public GameObject progressTextObject;
	public GUIText textFieldGUIObject;

	// Use this for initialization
	void Start () {
		progressTextObject = gameObject;
		progressTextObject.GetComponent<GUIText>().anchor = TextAnchor.UpperLeft;

		textFieldGUIObject = progressTextObject.GetComponent<GUIText>();

		getProgressField = GameObject.Find ("GameObject").GetComponent<TextField>();
	}
	
	// Update is called once per frame
	void Update () {
		textFieldGUIObject.text = getProgressField.InputString;
	}
}
