using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public bool IniciarEnMovimiento = false;
	public float velocidad = 0;
	private bool enMovimiento = false;
	private float tiempoInicio = 0f;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoEmpiezaCorrer");
		NotificationCenter.DefaultCenter().AddObserver(this, "CaracolitoMurio");
		if (IniciarEnMovimiento) {
			enMovimiento = true;
		}

	}

	void CaracolitoMurio(){
		enMovimiento = false;
	}

	void CaracolitoEmpiezaCorrer(){
		enMovimiento = true;
		tiempoInicio = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (enMovimiento) {
			gameObject.GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (((Time.time - tiempoInicio) * velocidad) % 1, 0);
			}
		}
}
