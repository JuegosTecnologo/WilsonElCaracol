using UnityEngine;
using System.Collections;

public class puntosBloque : MonoBehaviour {

	public int puntosPorBloque = 1;
	private bool haColisionadoConElJugador = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(!haColisionadoConElJugador && collision.gameObject.tag == "Player"){
			
			GameObject obj = collision.contacts [0].collider.gameObject;
			if (obj.name == "RueditaTrasera" ||  obj.name == "RueditaDelantera") {
				Debug.Log (obj.name);
				haColisionadoConElJugador = true;
				NotificationCenter.DefaultCenter ().PostNotification (this, "IngrementarPuntos", puntosPorBloque);
			}
		}
	}
}
