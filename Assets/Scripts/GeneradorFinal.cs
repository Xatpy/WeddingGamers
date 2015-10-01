using UnityEngine;
using System.Collections;

public class GeneradorFinal : MonoBehaviour {

    public float EndTime = 5.0f;

    public GameObject objGirlFriend;
    private bool complete = false;


    float CurrentTime = 0.0f;
    bool bCorriendo = false;

	// Use this for initialization
	void Start () {
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeEmpiezaACorrer");
	}
	
	// Update is called once per frame
	void Update () {
        CurrentTime += Time.deltaTime;
        if ((bCorriendo) && (CurrentTime > EndTime) && (!complete))
        {
            complete = true;
            GenerateEnd();
        }
	}

    void GenerateEnd()
    {
        Instantiate(objGirlFriend, transform.position, Quaternion.identity);
    }

    void PersonajeEmpiezaACorrer()
    {
        CurrentTime = 0.0f;
        bCorriendo = true;
    }
}
