using UnityEngine;
using System.Collections;

public class pointer : MonoBehaviour  // sets the properties of the cursor pointer
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
}

