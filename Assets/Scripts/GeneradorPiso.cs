using UnityEngine;
using System.Collections;

public class GeneradorPiso : MonoBehaviour {

	public GameObject[] objPiso;
	public float tiempoMinPiso = 1f;
	public float tiempoMaxPiso = 1.2f;

	// Use this for initialization
	void Start () {
		//GenerarPiso ();
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoEmpiezaCorrer");
	}

	void CaracolitoEmpiezaCorrer(Notification notificacion){
		GenerarPiso ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	void GenerarPiso(){
		Instantiate (objPiso [Random.Range (0, objPiso.Length)], transform.position, Quaternion.identity);
		Invoke("GenerarPiso", Random.Range(tiempoMinPiso, tiempoMaxPiso));
	}
}
