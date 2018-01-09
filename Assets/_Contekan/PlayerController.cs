using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 5f;

	public float bataskanan = 3f;
	public float bataskiri = -3f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			JalanKanan();
		}

		if (Input.GetKey (KeyCode.A)) {
			JalanKiri();
		}
			
	}

	void JalanKanan(){
		if(transform.position.x < bataskanan){
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		}

	}

	void JalanKiri(){
		if (transform.position.x > bataskiri) {
			transform.Translate (Vector2.left * speed * Time.deltaTime);
		}

	}
}
