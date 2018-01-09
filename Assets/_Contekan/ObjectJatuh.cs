using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TipeObject
{
	Telur,
	Bom,
}

public class ObjectJatuh : MonoBehaviour {

	public TipeObject type;
	public int AmountEffect = 1;

	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "Player") {
			if (type == TipeObject.Telur) {
				//Nambah Score
				Debug.Log("Score nambah 1 coy");
				GamesManager.Instance.AddScore(AmountEffect);
			}

			if (type == TipeObject.Bom) {
				//Ngurangin nyawa
				Debug.Log("Score ngurang 1 coy");
				GamesManager.Instance.DecreaseLives(AmountEffect);
			}
		}
	}

}
