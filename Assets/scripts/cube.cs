using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour { //color picker

	// Use this for initialization
	void OnMouseUp () {
		holder.bgcolor = GetComponent<Renderer>().material.color; // changes background color for the next scene
		holder.newgame = true; // indicates start of a new game

		Application.LoadLevel(Application.loadedLevel + 1); //goes to next level
	}

}
