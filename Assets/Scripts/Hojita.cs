using UnityEngine;
using System.Collections;

public class Hojita : MonoBehaviour {

	public int puntosPorHojita = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "IngrementarPuntos", puntosPorHojita);
		}
		Destroy (gameObject);
	}
}
