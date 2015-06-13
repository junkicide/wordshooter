using UnityEngine;
using System.Collections;

public class cam : MonoBehaviour { // sets background color

	public GUISkin ScoreSkin;

	// Use this for initialization
	void Start () {
		Camera.main.backgroundColor = holder.bgcolor; 

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
