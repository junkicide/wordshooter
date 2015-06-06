using UnityEngine;
using System.Collections;

public class pointer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		transform.position = new Vector3 (ray.GetPoint(10f).x, ray.GetPoint(10f).y, -1f);
	}


	// Update is called once per frame

}
