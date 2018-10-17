using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditionstatements : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int a = 4;
		int b = 2;
		int c = 8;
		//operators <, >, = , <=, >=
		if(a > b) {
			print("a is greater than b");
			if(a < 2){
				print("a is lower than 2")
			}
		} else if (a == b){
			print("a equals b");
		} 
		else {
			print("a is not greater than a");
		}
		if(true){
			print("The statement is true");
		}

		//switch statements 
		switch(a){
			//tests if letters equal these values
			case 1:
			break;
			case 5:
			break;
			case 4: 
			print ("a is equal to 6");
			break;
			default:
			print("no case is executed, only default is executed");
		}

	//executes only if both conditions are right
		if(a < b && a > c){
			print("this is true");
		}
	
//is executes if either one is true
			if(a < b || a > c){
			print("this is true");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}