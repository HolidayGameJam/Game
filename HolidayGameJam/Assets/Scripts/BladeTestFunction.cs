using UnityEngine;
using System.Collections;

public class BladeTestFunction : MonoBehaviour {

	public TextField Blade;

	private GameObject picture;
	private Transform pictureTransform;
	private Vector3 position;

	// Use this for initialization
	void Start () {
		Blade = GameObject.Find("GameObject").GetComponent<TextField>();
		picture = GameObject.Find ("New Sprite");
		pictureTransform = picture.transform;
		position = pictureTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Blade.InputString == "Booyah")
		{
			Vector3 tempvect = new Vector3(pictureTransform.position.x, pictureTransform.position.y+20.0f, pictureTransform.position.z);
			position = tempvect;
			Debug.Log("Hello");
		}
		else
		{
			//Debug.Log("Nope");
		}
	}
}
