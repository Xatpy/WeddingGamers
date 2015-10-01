using UnityEngine;
using System.Collections;

public class FinalPartida : MonoBehaviour {

	// Use this for initialization
	void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "FinalPartida");
        }
        Destroy(gameObject);
    }
}
