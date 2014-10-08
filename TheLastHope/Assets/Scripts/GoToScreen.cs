using UnityEngine;
using System.Collections;

public class GoToScreen : MonoBehaviour {
	private bool isSelected = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		if (!isSelected) {
			Vector3 seleccion = new Vector3 ((transform.position.x + 0.01f), 0.2f, 0);
			transform.position = seleccion;
			isSelected = true;
				} else {
			Vector3 seleccion = new Vector3 ((transform.position.x - 0.01f), 0.2f, 0);
			transform.position = seleccion;
			isSelected = false;
				}
	}

	void OnMouseEnter() {
		transform.localScale = new Vector3 (0.05f, 0.05f, 0);
	}

	void OnMouseExit() {
		transform.localScale = new Vector3 (0, 0, 0);
	}
}
