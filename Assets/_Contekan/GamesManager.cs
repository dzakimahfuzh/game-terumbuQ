using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesManager : MonoBehaviour {

	public static GamesManager Instance;

	public int Score;
	public int HiScore;

	public int Lives = 3;

	private void Awake(){
		Instance = this;
	}


	// Use this for initialization
	void Start () {
		Score = 0;
		HiScore = PlayerPrefs.GetInt ("scorePlayer");
	}

	public void AddScore(int Value){
		Score += Value;
	}

	public void DecreaseLives(int Value){
		Lives -= Value;
		if (Lives <= 0) {
			GameOver ();
		}
	}

	public void GameOver()
	{
		Debug.Log ("Game Over");
		if (Score > HiScore) {
			HiScore = Score;
			PlayerPrefs.SetInt ("scorePlayer", HiScore);
		}
	}
}
