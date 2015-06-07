using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (transform.position.x, transform.position.y - 0.5f*Time.deltaTime, transform.position.z);
		}

	void OnBecameInvisible()
	{
			transform.position = new Vector3 (transform.position.x, 6f, transform.position.z);
		}
	void OnMouseDown()
	{
		wordcontrol.addletter(gameObject.transform.FindChild("text").GetComponent<TextMesh>().text);
			Destroy(gameObject);
		}

}
