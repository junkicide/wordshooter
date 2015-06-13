using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour { // ball properties
	public string letter;
	// Use this for initialization
	void Start () {


		transform.position = new Vector3 (transform.position.x, 6f, transform.position.z); // set initial position
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Find("txt").gameObject.GetComponent<TextMesh>().text = letter; //updates text mesh to letter assigned by gamecontol
		transform.position = new Vector3 (transform.position.x, transform.position.y - 1f*Time.deltaTime, transform.position.z); //updates positiion
		}

	void OnBecameInvisible()
	{
		Start (); // in case balls go out of view go back to initial position
		}
	void OnMouseDown()
	{
		gamecontrol.aword += letter; // add letter to word on click
		Application.LoadLevel(Application.loadedLevel); // reload level
		}

}
