using UnityEngine;
using System.Collections;

public class Hojita : MonoBehaviour {
	public AudioClip hojita;
	public int puntosPorHojita = 5;
	public float itemSoundVolume = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			AudioSource.PlayClipAtPoint (hojita, Camera.main.transform.position, itemSoundVolume);
			NotificationCenter.DefaultCenter ().PostNotification (this, "IngrementarPuntos", puntosPorHojita);
		}
		Destroy (gameObject);
	}
}
