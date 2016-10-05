using UnityEngine;
using System.Collections;

public class GeneradorElementosVarios : MonoBehaviour {

	public GameObject[] objVario;
	public float tiempoMinPiso = 5f;
	public float tiempoMaxPiso = 15f;

	private bool fin = false;

	// Use this for initialization
	void Start () {
		//GenerarPiso ();
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoEmpiezaCorrer");
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoMurio");
	}

	void CaracolitoEmpiezaCorrer(Notification notificacion){
		GenerarElementoVario ();
	}

	void CaracolitoMurio(){
		fin = true;
	}
	// Update is called once per frame
	void Update () {
	
	}

	void GenerarElementoVario(){
		if (!fin) {
			Instantiate (objVario [Random.Range (0, objVario.Length)], transform.position, Quaternion.identity);
			Invoke ("GenerarElementoVario", Random.Range (tiempoMinPiso, tiempoMaxPiso));
		}
	}
}
