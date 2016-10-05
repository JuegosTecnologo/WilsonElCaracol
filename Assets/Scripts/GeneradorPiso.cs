using UnityEngine;
using System.Collections;

public class GeneradorPiso : MonoBehaviour {

	public GameObject[] objPiso;
	public float tiempoMinPiso = 1f;
	public float tiempoMaxPiso = 1.2f;

	private bool fin = false;
	// Use this for initialization
	void Start () {
		//GenerarPiso ();
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoEmpiezaCorrer");
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoMurio");
	}

	void CaracolitoEmpiezaCorrer(Notification notificacion){
		GenerarPiso ();
	}

	void CaracolitoMurio(){
		fin = true;
	}

	// Update is called once per frame
	void Update () {
	
	}

	void GenerarPiso(){
		if (!fin) {
			Instantiate (objPiso [Random.Range (0, objPiso.Length)], transform.position, Quaternion.identity);
			Invoke ("GenerarPiso", Random.Range (tiempoMinPiso, tiempoMaxPiso));
		}
	}
}
