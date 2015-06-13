using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {
	public GUISkin ScoreSkin;
	// Use this for initialization
	void Start () {
	
	}
	void OnGUI()
	{
		if (GUI.skin != ScoreSkin)
		{
			GUI.skin = ScoreSkin;
		}
		
		GUI.Label (new Rect(10,10,300,30), "Your word: " + gamecontrol.qword);
		GUI.Label (new Rect(10,35,300,30), "progress: " + gamecontrol.aword);
		GUI.Label (new Rect(10,60,300,30), "turns: " + holder.turns.ToString());

	}
	// Update is called once per frame
	void Update () {
	
	}
}
