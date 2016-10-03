using UnityEngine;
using System.Collections;

public class GeneradorElementosVarios : MonoBehaviour {

	public GameObject[] objVario;
	public float tiempoMinPiso = 5f;
	public float tiempoMaxPiso = 15f;

	// Use this for initialization
	void Start () {
		//GenerarPiso ();
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoEmpiezaCorrer");
	}

	void CaracolitoEmpiezaCorrer(Notification notificacion){
		GenerarElementoVario ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	void GenerarElementoVario(){
		Instantiate (objVario [Random.Range (0, objVario.Length)], transform.position, Quaternion.identity);
		Invoke("GenerarElementoVario", Random.Range(tiempoMinPiso, tiempoMaxPiso));
		Debug.Log ("SE GENERA ELEMENTO VARIO");
	}
}
