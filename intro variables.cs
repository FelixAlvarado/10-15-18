using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tester : MonoBehaviour {

	
	// Use this for initialization
	//gets called when you call game 
	void Start () {
		int a = 10; 
		int b = 6;
		int sum = a / b;

	//the float would yeild and error because can't convert int to float. 
	//floats cannot convert to integers, but integers can convert to floats (same with doubles)
	// int = float + float would not yeild error
		// float a = 10; 
		// float b = 6;
		// int sum = a / b;

	//you can utilize casting to prevent error 
		// float a = 10; 
		// float b = 6;
		// int sum = (int)a / (int)b;
		//can do - for subtract, * for multiplication. 

		//5/6 would be 0 

		// 8/6 would be 1. need variables to be floats to get a float answer
		//print to console. integers round to closest whole number  (rounded down all the time)

		print (sum);
		// Debug.log(sum);

		//concatination
		print ("The sum of a and b is " + sum);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

//variable intro notes 

//f at the end means its a float. not having float will yeild an error

	/*another comment */

	//in c# must type type of variable, then name, then value

	//want to give meaninful names 

	//float of 32 bit number, and double is 64 bit number. doubles are more precise. double doesn't need ending  letter 
	// float power = 2.1f;

	//could put d at end if you want to but not neccisary 
	// double health = 3.5;

	//integers 

	// int score = 44;

	//strings 

	// string name = "wizard";

	//boolean 

	// bool isAlive = false;

