using UnityEngine;
using System.Collections;

public class GeneradorLand : MonoBehaviour {

	public GameObject[] objLand;
	public float tiempoMinLand = 1f;
	public float tiempoMaxLand = 3f;

	private bool fin = false;
	// Use this for initialization
	void Start () {
		//GenerarLand ();
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoEmpiezaCorrer");
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoMurio");
	}

	void CaracolitoEmpiezaCorrer(Notification notificacion){
		GenerarLand ();
	}
	void CaracolitoMurio(){
		fin = true;
	}
	void GenerarLand(){
		if (!fin) {
			Instantiate (objLand [Random.Range (0, objLand.Length)], transform.position, Quaternion.identity);
			Invoke ("GenerarLand", Random.Range (tiempoMinLand, tiempoMaxLand));
		}
	}
}
