using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectJatuh : MonoBehaviour {

	public int AmountEffect = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entering" + collision.gameObject.name);
        if (collision.gameObject.tag == "Terumbu")
        {
            collision.gameObject.GetComponent<TerumbuQ>().decreaseLives(AmountEffect);
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

}
