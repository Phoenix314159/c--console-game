﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a Number in your head but don't tell me!");
		print ("Only pick a whole number!");
		print ("The highest number you can pick is " + max + ".");
		print ("The lowest number you can pick is " + min + ".");
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
		max = max + 1;
	}
	void NextGuess() {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("Up = higher, down = lower, return = equal");
	}

	void Start () {
		StartGame();
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		}else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
			StartGame ();
		}
	}
}
