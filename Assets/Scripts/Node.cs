using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public Vector3 positionOffset;

	private GameObject turret;

	private Renderer rend;
	private Color startColor;

	void Start ()
	{
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
	}

	void OnMouseDown ()
	{
		if (turret != null)
		{
			Debug.Log("Can't build there! - TODO: Display on screen");
			return;
		}

		GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
		turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
	}

	void OnMouseEnter ()
	{
		rend.material.color = hoverColor;
	}

	void OnMouseExit()
	{
		rend.material.color = startColor;
	}
	// void Update() {

	// 	Touch myTouch = Input.GetTouch(0);
	// 	Touch[] myTouches = Input.touches;
	// 	for (int i = 0; i < Input.touchCount; i++) {
	// 		Debug.Log ("Hej!");
	// 	}
	// }
}
