using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerumbuQ : MonoBehaviour {

	public Sprite sehat; //gambar kondisi trumbu sehat
	public Sprite rusak; //gambar kondisi trumbu sakit

    public Image HealthBar; //healthbar bertipe fill

	public static TerumbuQ Instance;

	public int lives = 5; //set nyawa
    private int maxLives; // maxNyawa

	// Use this for initialization
	void Start () { //ketika game dijalankan
        maxLives = lives; //set maxNyawa sesuai nyawa
		GetComponent<SpriteRenderer> ().sprite = sehat; //gunakan gambar trumbu karang yang sehat
	}

	public void decreaseLives (int Value){ //method yang di panggil saat bom menyentuh terumbu karang
		lives -= Value; //kurangi nyawanya sesuai argumen
        HealthBar.fillAmount = (float)lives / (float)maxLives; //ubah tambilan healthbar
		if (lives <= 0) { //jika nyawanya habis
			Debug.Log("Terumbuh Hancurh");
			GamesManagement.Instance.decreaseMainLives (1); //kurangi nyawa main lifes pada GamesManagement

			GetComponent<SpriteRenderer> ().sprite = rusak; //ubah gambar terumbu karang menjadi kondisi rusak
		}
			
	}
		


		
}
