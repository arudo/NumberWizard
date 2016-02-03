using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//	print ("Up arrow pressed");
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//	print ("Down arrow pressed");
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		guess = Random.Range (min, max);
	
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me:");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up Arrow for higher, Down Arrow for lower, Enter for equals");
		
		max = max + 1;
	}
	
	void NextGuess() {
		guess = Random.Range (min, max);
		print ("Higher or lower than " + guess + "?");
		print ("Up Arrow for higher, Down Arrow for lower, Enter for equals");
	}
}
