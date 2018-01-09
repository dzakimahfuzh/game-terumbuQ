using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerumbuQ : MonoBehaviour {

	public Sprite sehat;
	public Sprite rusak;

	public static TerumbuQ Instance;

	public int lives = 5;

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = sehat;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void decreaseLives (int Value){
		lives -= Value;
		if (lives <= 0) {
			Debug.Log("Terumbuh Hancurh");
			GamesManagement.Instance.decreaseMainLives (1);

			GetComponent<SpriteRenderer> ().sprite = rusak;
		}
			
	}
		


		
}
