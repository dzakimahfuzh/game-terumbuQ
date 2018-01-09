using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectJatoh : MonoBehaviour {

	public int AmountEffect = 1;

	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "Player") {
			collision.GetComponent<TerumbuQ> ().decreaseLives (AmountEffect);
		}
	}

}
