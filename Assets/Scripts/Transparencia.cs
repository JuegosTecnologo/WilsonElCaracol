using UnityEngine;
using System.Collections;

public class Transparencia : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Color tmp = gameObject.GetComponent<SpriteRenderer>().color;
		tmp.a = 1f;
		gameObject.GetComponent<SpriteRenderer>().color = tmp;
	}
}
