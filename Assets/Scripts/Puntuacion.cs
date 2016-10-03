using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

	public int puntuacion = 0;
	public TextMesh Marcador;
	// Use this for initialization
	void Start () {
		ActualizarMarcador ();
		NotificationCenter.DefaultCenter ().AddObserver (this, "IngrementarPuntos");

	}

	void IngrementarPuntos(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;
		puntuacion += puntosAIncrementar;
		ActualizarMarcador ();
		Debug.Log("Incrementando "+puntosAIncrementar+" - TOTAL: "+puntuacion);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
	void ActualizarMarcador () {
		Marcador.text = puntuacion.ToString();
	}
}
