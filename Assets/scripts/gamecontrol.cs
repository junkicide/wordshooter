using UnityEngine;
using System.Collections;

public class gamecontrol : MonoBehaviour { // controls ball instantiating, letter assigning, what to do if round is over
	string possible = "qwertyuiopasdfghjklzxcvbnm";
	string[] words = { "purple", "orange", "sepia", "silver", "ivory", "beige", "teal", "fuchsia", "turqoise" };
	public static string qword;
	public static string aword;
	public static int ctr;
	public Ball ball;

	// Use this for initialization
	void Start () {
		if (holder.newgame== true) // initialising all the necessary variables
		{
		qword = words[Random.Range (0, words.Length)]; // word is picked from list
			aword=""; // container of the shot letters
			ctr=0; //points to the current letter of qword
			holder.newgame=false;
			holder.turns++; // increase number of turns
		}

		if (ctr < qword.Length) {

		Ball ball1 =  Instantiate(ball, new Vector3(0, 0, 0), Quaternion.identity) as Ball; // instantiating number of balls
		Ball ball2 = Instantiate(ball, new Vector3(-6, 0, 0), Quaternion.identity)as Ball;
		Ball ball3 = Instantiate(ball, new Vector3(6, 0, 0), Quaternion.identity)as Ball;
		pickballs(ball1, ball2, ball3);
		

		}

		if (ctr == (qword.Length)){
			Application.LoadLevel(Application.loadedLevel - 1); // go back to previous scene, where the result is shown
			}
		ctr++;
		}



	 void pickballs(Ball b1, Ball b2, Ball b3) { // picks the ball to be given the correct letter randomly 
		//and assigns random letters to other two

		int picker = Random.Range(1, 4);
		if (picker==1) {
			b1.GetComponent<Ball>().letter = "" + qword[ctr];
			
			b2.GetComponent<Ball>().letter = "" + randletter (qword[ctr]);
			
			b3.GetComponent<Ball>().letter = "" + randletter (qword[ctr]);
		}
		else if (picker ==2) {
			b1.GetComponent<Ball>().letter = "" + randletter (qword[ctr]);
			
				b2.GetComponent<Ball>().letter = "" + qword[ctr];
			
			b3.GetComponent<Ball>().letter = "" + randletter (qword[ctr]);
		}

		else if (picker ==3) {
			b1.GetComponent<Ball>().letter = "" + randletter (qword[ctr]);
			
			b2.GetComponent<Ball>().letter = "" + randletter (qword[ctr]);
			
			b3.GetComponent<Ball>().letter = "" +  qword[ctr];
		}
	}

	public char randletter (char a){ // function to make sure that two balls dont have the correct letter

		while (true)
		{
			char l= possible[Random.Range(0, possible.Length)];
			if (l!=a) {
				return l;
			}
			else{
				continue;
			}
		}
	}


	// Update is called once per frame

}
