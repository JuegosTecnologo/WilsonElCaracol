using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			NotificationCenter.DefaultCenter ().PostNotification (this, "CaracolitoMurio");
			GameObject personaje = GameObject.Find ("Caracolito");
			personaje.SetActive (false);

			//GAME OVER (Se cayó)
			//Debug.Break ();

		} else {
			Destroy (other.gameObject);
		}

	}

}
