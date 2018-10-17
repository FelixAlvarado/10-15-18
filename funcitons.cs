using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// CalculateTwoNumbers(4,5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//functions that start with void don't return values 
	// void CalculateTwoNumbers() {
	// 	print("The sum of a and b is " + (3 + 5));
	// }
//using parameters
	// void CalculateTwoNumbers(int a, int b){
	// 	print("The sum of a and b is " + (a + b));
	// }
//function that returns integers 
//cant have two functions of the same name (but can if one is void and another is int etc... && one takes parameters while the other doesn't)
int CaculateTwoNumbers() {
	return 5 + 5;
}
	
}
