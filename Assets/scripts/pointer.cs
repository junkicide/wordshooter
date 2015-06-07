using UnityEngine;
using System.Collections;

public class pointer : MonoBehaviour 
{
	public Texture2D cursorImage;
	
	private int cursorWidth = 50;
	private int cursorHeight = 32;
	
	void Start()
	{
		Cursor.visible = false;
	}
	
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Input.mousePosition.x - cursorWidth/2, Screen.height- Input.mousePosition.y - cursorHeight/2, cursorWidth, cursorHeight), cursorImage);
	}
}/*using UnityEngine;
using System.Collections;

public class pointer : MonoBehaviour {
	int w = 3;
	int h = 1;
	Vector2 mouse;
	public Texture2D texture;
	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		transform.position = new Vector3 (ray.GetPoint(10f).x, ray.GetPoint(10f).y, -1f);
	}
	
	void Update()
	{
		 mouse = new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y);
	}
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(mouse.x -w/2, mouse.y - h/2, w, h),texture );
	}
	// Update is called once per frame

}
*/