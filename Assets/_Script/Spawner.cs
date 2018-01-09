using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] TheObject;

	public int[] timer;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnObject", timer[Random.Range (0, timer.Length)]);
	}

	public void SpawnObject(){
		int RandomObjectIndex = Random.Range (0, TheObject.Length);
		Instantiate (TheObject [RandomObjectIndex], new Vector3 (this.transform.position.x, 
			this.transform.position.y, this.transform.position.z), Quaternion.identity);
		Invoke ("SpawnObject", timer [Random.Range (0, timer.Length)]);
	}
}
