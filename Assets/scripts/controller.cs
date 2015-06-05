using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
	public string possible = "abcdefghijklmnopqrstuvwxyz";
	string[] words = { "purple", "orange", "month", "silver" };
	int ctr = 0;
	string word;
	int turns = 0;
	

	// Use this for initialization
	 void Start () {
	string word = words[Random.Range(0, words.Length)];
		turns ++;
	
	int chooseball = Random.Range(1, 4);

		inittext(word, chooseball);
		dropballs();
}
	
	// Update is called once per frame
	void Update () {
				
			
	
	}
		 void inittext(string w, int ball){
			if (ball == 1){
			GameObject.Find("2").GetComponent<TextMesh>().text = "" + possible[Random.Range (0,possible.Length)];
			GameObject.Find("3").GetComponent<TextMesh>().text = "" +possible[Random.Range (0,possible.Length)];
			GameObject.Find(ball.ToString()).GetComponent<TextMesh>().text = "" + w[ctr];
			
		}
		else if (ball == 2) {
			GameObject.Find("1").GetComponent<TextMesh>().text = "" + possible[Random.Range (0,possible.Length)];
			GameObject.Find("3").GetComponent<TextMesh>().text = "" + possible[Random.Range (0,possible.Length)];
			GameObject.Find(ball.ToString()).GetComponent<TextMesh>().text = "" + w[ctr];
		}
		else {
			GameObject.Find("1").GetComponent<TextMesh>().text = "" + possible[Random.Range (0,possible.Length)];
			GameObject.Find("2").GetComponent<TextMesh>().text = "" + possible[Random.Range (0,possible.Length)];
			GameObject.Find(ball.ToString()).GetComponent<TextMesh>().text = "" + w[ctr];
		}
}
}
