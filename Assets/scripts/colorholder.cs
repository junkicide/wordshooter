﻿using UnityEngine;
using System.Collections;

public class colorholder : MonoBehaviour {

	public static Color bgcolor;
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
