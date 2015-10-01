﻿using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

	private int key = 0;
	private int _puntuacion = 0;
	public int puntuacion{
		get { return _puntuacion ^ key; }
		set {
			key = Random.Range(0,int.MaxValue);
			_puntuacion = value ^ key;
		}
	}
	public TextMesh marcador;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
		ActualizarMarcador();
        //NotificationCenter.DefaultCenter().AddObserver(this, "FinalPartida");
	}
	
	void PersonajeHaMuerto(Notification notificacion){
		if(puntuacion > EstadoJuego.estadoJuego.puntuacionMaxima){
			EstadoJuego.estadoJuego.puntuacionMaxima = puntuacion;
			EstadoJuego.estadoJuego.Guardar();
		}
		
        /*
		// Enviamos a Google Play Games la puntuacion obtenida
		Social.ReportScore(puntuacion, "CgkI1-mG67sBEAIQBg", (bool success) => {});
		
		// Activamos las medallas correspondientes
		if(puntuacion>=25){
			Social.ReportProgress("CgkI1-mG67sBEAIQAQ", 100.0, (bool success) => {});
		}
		if(puntuacion>=50){
			Social.ReportProgress("CgkI1-mG67sBEAIQAg", 100.0, (bool success) => {});
		}		
		if(puntuacion>=100){
			Social.ReportProgress("CgkI1-mG67sBEAIQAw", 100.0, (bool success) => {});
		}	
		if(puntuacion>=150){
			Social.ReportProgress("CgkI1-mG67sBEAIQBA", 100.0, (bool success) => {});
		}	
		if(puntuacion>=200){
			Social.ReportProgress("CgkI1-mG67sBEAIQBQ", 100.0, (bool success) => {});
		}	
		*/				
	}

	void IncrementarPuntos(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;
		puntuacion+=puntosAIncrementar;
		ActualizarMarcador();
	}

	void ActualizarMarcador(){
		marcador.text = puntuacion.ToString();
	}

    void FinalPartida(Notification notificacion)
    {
        //Debug.Log("hola caracola...se acabo la partida hamijos!");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
