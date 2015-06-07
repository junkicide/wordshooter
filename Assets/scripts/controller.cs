using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
	public string possible = "abcdefghijklmnopqrstuvwxyz";
	string[] words = { "purple", "orange", "month", "silver" };
	int ctr = 0;
	string word;
	int turns = 0;
	Ball ballprefab;
	Ball ball1;
	Ball ball2;
	Ball ball3;
	
	

	// Use this for initialization
	 void Start () {
		ball1 = Instantiate (ballprefab) as Ball;
		ball2 = Instantiate (ballprefab) as Ball;
		ball3 = Instantiate (ballprefab) as Ball;


		ball2.transform.position=  new Vector3(0, 6, 0);
		ball3.transform.position = new Vector3(5, 6, 0);

	string word = words[Random.Range(0, words.Length)];
		turns ++;
	
	int chooseball = Random.Range(1, 4);

		inittext(word);
		//startRound();
}
	
	// Update is called once per frame
	void Update () {
				
			
	
	}
		 void inittext(string w){
		GameObject.Find ("ball1").transform.FindChild("text").gameObject.GetComponent<TextMesh>().text = "" + randletter(w[ctr]);
		GameObject.Find ("ball2").transform.FindChild("text").gameObject.GetComponent<TextMesh>().text = "" + randletter(w[ctr]);
		GameObject.Find ("ball3").transform.FindChild("text").gameObject.GetComponent<TextMesh>().text = "" + w[ctr];
}

	char randletter (char a)
	{
	while (true)
	{
			char l= possible[Random.Range(0, possible.Length)];
		if (l==a){
			continue;
			}
		else{
			return l;
			break;
			}
		}
	}

}
