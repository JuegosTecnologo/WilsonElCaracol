using UnityEngine;
using System.Collections;

public class ActivarGameOver : MonoBehaviour {

	public GameObject camaraGameOver;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoMurio");
	}
	
	void CaracolitoMurio(Notification notificacion){

		camaraGameOver.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
