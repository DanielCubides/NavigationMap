using UnityEngine;
using System.Collections;

public class GoToScreen : MonoBehaviour {
	public string nombreNivel;
	//private bool isSelected = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Application.LoadLevel (nombreNivel);

	}

	void OnMouseEnter() {
		transform.localScale = new Vector3 (transform.localScale.x + 0.01f,transform.localScale.y + 0.01f, transform.localScale.z);
		Vector3 seleccion = new Vector3 ((transform.position.x + 0.01f), transform.position.y, 0);
		transform.position = seleccion;
	}

	void OnMouseExit() {
		transform.localScale = new Vector3 (transform.localScale.x - 0.01f,transform.localScale.y - 0.01f, transform.localScale.z);
		Vector3 seleccion = new Vector3 ((transform.position.x - 0.01f), transform.position.y, 0);
		transform.position = seleccion;
	}
}
