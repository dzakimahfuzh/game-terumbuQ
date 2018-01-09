using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamesManagement : MonoBehaviour {

	public static GamesManagement Instance;

    public GameObject WinPanel; //panel yang akan muncul ketika menang
    public GameObject LosePanel; //panel yang akan muncul ketika kalah

    public int mainLives = 3; //jumlah nyawa

    public float DurasiPermainan; //durasi permainan dalam satuan detik
    public Text LabelTimer; //label timer UI

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1.0f; //menjadikan timescale menjadi 1 (agar game tidak terhenti / paused)
        WinPanel.SetActive(false); //memastikan panel win mati 
        LosePanel.SetActive(false); //memastikan panel lose mati
        StartCoroutine(Timer()); //memanggil fungsi timer
    }

    public void decreaseMainLives(int Life){ //fungsi mengurangi darah
		mainLives -= Life; //mengurangi value mainLive sesuai dengan argument 
		if (mainLives <= 0) { //pengedekan jika mainLives habis
			Debug.Log ("UDAH MATI COOOY");

            WinPanel.SetActive(false); //matikan panel win
            LosePanel.SetActive(true); //nyalakan panel lose
            Time.timeScale = 0.0f; //timescale menjadi nol untuk pause game
        }
	}

    IEnumerator Timer() //fungsi timer
    {
        while(DurasiPermainan > 0) //selama durasi masih diatas nol maka lakukan :
        {
            DurasiPermainan--; //kurangi waktu 1 unit (detik)
            LabelTimer.text = "" + DurasiPermainan +" Detik"; //ubah label timer pada User Interface menjadi tampilan seperti berikut : "x Detik"
            yield return new WaitForSeconds(1f); //melakukan jeda selama 1 detik
        } //jika kondisi while sudah tidak terpenuhi, alias timer habis, maka :
        WinPanel.SetActive(true);  //tampilkan panel menang
        LosePanel.SetActive(false); //matikan panel lose
        Time.timeScale = 0.0f; //set timescale ke nol untuk pause game
    }

    public void QuitGame() //method yang di panggil oleh button quit pada panel lose dan win
    {
        Application.Quit();  //method quit game
    }

    public void RestartGame() //method yang di panggil pada button restart game di panel win dan lose
    {
        Application.LoadLevel(Application.loadedLevel); //method untuk restart game
    }
}
