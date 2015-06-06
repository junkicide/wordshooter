using UnityEngine;
using System.Collections;

public class ballmotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (transform.position.x, transform.position.y - 0.5f*Time.deltaTime, transform.position.z);
		}

	void OnBecameInvisible()
	{
			transform.position = new Vector3 (transform.position.x, 10f, transform.position.z);
		}
	void OnMouseDown()
	{

			Destroy(gameObject);
		}

}
