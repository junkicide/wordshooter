using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {

	// Use this for initialization
	void OnMouseUp () {
		colorholder.bgcolor = GetComponent<Renderer>().material.color;
		Application.LoadLevel(Application.loadedLevel + 1);
	}

}
