using UnityEngine;
using System.Collections;

public class result : MonoBehaviour { // GUI component which shows the result + other sundries
	public GUISkin ScoreSkin;
	// Use this for initialization
	void Start () {
	
	}
	void OnGUI()
	{
		if (GUI.skin != ScoreSkin)
		{
			GUI.skin = ScoreSkin; // setting the GUI Skin
		}
		

		GUI.Label (new Rect(100,150,300,30), "Select Background Color");

		if (holder.turns!=0)
		{
			if (gamecontrol.aword == gamecontrol.qword) // checking if shot word is the same as given word
			{
			GUI.Label (new Rect(400,35,300,30), "YOU WON!" );
			}
			else {
			GUI.Label (new Rect(400,35,300,30), "YOU LOST!");
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
