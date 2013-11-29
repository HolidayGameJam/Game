using UnityEngine;
using System.Collections;

public class TextField : MonoBehaviour {

	public string InputString = "";
	public string InputStringRefresh = "";

	public GUIStyle myGuiStyle;


	private string textStore;

	private int InputStringSize;

	private int lastCursorPos = 0;
	private int lastSelectCursorPos = 0;

	//private TextEditor te;
	private bool needsRefocus;

	void Start () {
		InputStringSize = InputString.Length;
		AssignTextStore();
	}

	void OnGUI() {
		Vector3 screenPos = Camera.main.WorldToScreenPoint (transform.position);
		GUI.SetNextControlName("MyTextField");
		GUI.color = new Color( 0, 0, 0, 0 );
		InputString = GUI.TextField(new Rect(screenPos.x,screenPos.y, 2000, 1000), InputString, 100);

		if (GUI.GetNameOfFocusedControl () != "MyTextField") 
		{
			needsRefocus = true;
		}
		
		//te = (TextEditor)GUIUtility.GetStateObject(typeof(TextEditor), GUIUtility.keyboardControl);

		if (needsRefocus)
		{
			needsRefocus = false;

			InputStringRefresh = InputString;

			GUI.FocusControl("MyTextField");
			
			//needs to be redefined after setting the FocusControl       
			//te = (TextEditor)GUIUtility.GetStateObject(typeof(TextEditor), GUIUtility.keyboardControl);  
			
			if (true)
			{
				//these two lines prevent a "select all" effect on the textfield which seems to be the default GUI.FocusControl behavior
				  //set cursor position
				//Debug.Log("Current letter position of LASTCURSORPOS " + lastCursorPos);
				//te.selectPos = lastSelectCursorPos;  //set selection cursor position
				//te.pos = lastCursorPos;
				//te.MoveCursorToPosition(new Vector2(5555, 5555));
				while (InputString != "")
				{
					InputString = "";
					InputStringSize = 0;
					Debug.Log("EMPTY YOURSELF");
				}

				Debug.Log("Current letter position of lastSelectCursorPos " + lastSelectCursorPos);
			}
			InputString = InputStringRefresh;
		}
		else if (true)
		{
			//lastCursorPos = te.pos;  //get cursor position on each update
			//lastSelectCursorPos = te.selectPos;  //get selection cursor position on each update
			Debug.Log("Current letter position of LASTCURSORPOS in after fun" + lastCursorPos);
		}

		SpellCheck ();
	} 

	void Update () {
	}

	void SpellCheck(){
		if (InputString.Length >= InputStringSize && InputString.Length > 0)
		{	
			if(InputString.Length > textStore.Length)
			{
				InputString = InputString.Substring(0, textStore.Length);
			}
			
			for (int i = 0; i < InputString.Length; i++)
			{
				//Debug.Log("Current letter of InputString is " + InputString[i]);
				if (textStore[i] != InputString[i])
				{
					InputString = InputString.Substring(0, i);
				}
			}
		}
		InputStringSize = InputString.Length;
	}

    void AssignTextStore() {
		textStore = GameObject.Find("Text Match").GetComponent<GUIText>().text;
		Debug.Log("Current textStore value is " + textStore);
	}
}
