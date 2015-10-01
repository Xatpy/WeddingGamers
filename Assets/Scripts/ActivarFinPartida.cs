using UnityEngine;
using System.Collections;

public class ActivarFinPartida : MonoBehaviour {

    public GameObject camaraGameOver;
    public AudioClip gameOverClip;

	// Use this for initialization
	void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "FinalPartida");	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FinalPartida(Notification notificacion)
    {
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().clip = gameOverClip;
        GetComponent<AudioSource>().loop = true;
        GetComponent<AudioSource>().Play();
        camaraGameOver.SetActive(true);
    }
}
