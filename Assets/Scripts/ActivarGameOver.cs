using UnityEngine;
using System.Collections;

public class ActivarGameOver : MonoBehaviour {

	public GameObject camaraGameOver;
	public AudioClip gameOver;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoMurio");
	}

	void CaracolitoMurio(Notification notificacion){
		GetComponent<AudioSource> ().Stop ();
		GetComponent<AudioSource> ().clip = gameOver;
		GetComponent<AudioSource> ().loop = false;
		GetComponent<AudioSource> ().Play ();
		camaraGameOver.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
