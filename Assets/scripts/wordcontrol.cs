using UnityEngine;
using System.Collections;

public class wordcontrol : MonoBehaviour {
	public static string finalword = "";
	// Use this for initialization
	void Start () {
	
	}

	public static void addletter (string a) {
		finalword+=a;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
