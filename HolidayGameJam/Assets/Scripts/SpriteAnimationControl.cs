using UnityEngine;
using System.Collections;

public class SpriteAnimationControl : MonoBehaviour {

	private string animMode;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		animateSprite ();
	}

	void animateSprite(){
		if (animMode == "talk")
		{
			//gameObject.GetComponent<SpriteRenderer>().sprite = Blade_Talk_Open;
		}
	}

	void Talk (bool animated, bool react){
		if (animated == true)
		{

		}
	}

	void Happy (bool animated, bool react){
		
	}

	void Angry (bool animated, bool react){
		
	}

	void Confused (bool animated, bool react){
		
	}
}
