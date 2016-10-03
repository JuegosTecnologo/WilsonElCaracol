using UnityEngine;
using System.Collections;

public class GeneradorLand : MonoBehaviour {

	public GameObject[] objLand;
	public float tiempoMinLand = 1f;
	public float tiempoMaxLand = 3f;

	// Use this for initialization
	void Start () {
		//GenerarLand ();
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoEmpiezaCorrer");
	}

	void CaracolitoEmpiezaCorrer(Notification notificacion){
		GenerarLand ();
	}

	void GenerarLand(){
		Instantiate (objLand [Random.Range (0, objLand.Length)], transform.position, Quaternion.identity);
		Invoke("GenerarLand", Random.Range(tiempoMinLand, tiempoMaxLand));
	}
}
