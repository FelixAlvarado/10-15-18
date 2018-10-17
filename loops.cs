using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
//i++ means use i then increment it ++i means increment i before using it
		for(int i = 0; i < 10; i++){
			print("The value of i is " + i);
		}

		int i = 0
		while(i < 10){
			print("The value of i is " + i);
			i++;
		}
		int j = 0;
		//do while loop executes codes before checkingf or condition
		do{
			j++
		}while(j < 10)
	}
	
	// Update is called once per frame
	void Update () {
		
	}