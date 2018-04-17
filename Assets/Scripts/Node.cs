using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

	public Color hoverColor;

	private Renderer rend;
	private Color startColor;

	void Start () {
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
	}

	void onMouseEnter () {
		rend.material.color = hoverColor;
	}

	void onMouseExit() {
		rend.material.color = startColor;
	}
	void Update() {
		
		Touch myTouch = Input.GetTouch(0);
		Touch[] myTouches = Input.touches;
		for (int i = 0; i < Input.touchCount; i++) {
			Debug.Log ("Hej!");
		}
	}
}
