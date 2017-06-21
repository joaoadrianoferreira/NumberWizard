using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min; 
	int guess;

	void Start () {
		StartGame(); 	
	}
	
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess; 
			NextGuess(); 
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;  
			NextGuess(); 
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!"); 
			StartGame(); 
		}
	}
	
	void StartGame () {
	
		max = 1000; 
		min = 1; 
		guess = 500; 
		
		print("=========================================="); 
		print("Welcome to Number Wizard"); 
		print("Pick a number in your head, but don't tell me!"); 
		
		print ("The highest number you can pick is " + max); 
		print ("The lowest number you can pick is " + min); 
		
		max = max + 1; 
		
		print ("Is your number higher or lower than " + guess + "?");
		print ("up = higher, down = lower, Return = equal");
	}
	
	void NextGuess() {
		guess = (min + max) / 2; 
		print ("Is your number higher or lower than " + guess + "?");
		print ("up = higher, down = lower, Return = equal");
	}
}
