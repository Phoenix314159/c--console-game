﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard");
		print ("Pick a Number in your head but don't tell me!");
		print ("Only pick a whole number!");

		int max = 1000;
		int min = 1;

		print ("The highest number you can pick is " + max + ".");
		print ("The lowest number you can pick is " + min + ".");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
