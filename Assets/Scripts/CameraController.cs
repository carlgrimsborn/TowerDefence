﻿using UnityEngine;

public class CameraController : MonoBehaviour {

	private bool doMovement = true;

	public float panSpeed = 30f;
	public float panBorderThickness = 10f;

	public float scrollSpeed = 5f;
	public float minY = 10f;
	public float maxY = 80f;

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			doMovement = !doMovement;
		}

		if (!doMovement)
		{
			return;
		}

		//on mobile version, this will be replaced by zoom in touch event
		if (Input.GetKey("a"))
		{
			transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("d"))
		{
			transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("w"))
		{
			transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
		}
		if (Input.GetKey("s"))
		{
			transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
		}

		//input will be changed to touch zoom event
		float scroll = Input.GetAxis("Mouse ScrollWheel");

		Vector3 pos = transform.position;

		pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
		pos.y = Mathf.Clamp(pos.y, minY, maxY);

		transform.position = pos;

		//TODO: change camera angle when zooming max
	}
}
