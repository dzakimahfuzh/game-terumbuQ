using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesManagement : MonoBehaviour {

	public static GamesManagement Instance;

	public int mainLives = 3;

	public void awake(){
		Instance = this;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void decreaseMainLives(int Life){
		mainLives -= Life;
		if (mainLives <= 0) {
			Debug.Log ("UDAH MATI COOOY");
		}
	}
}
