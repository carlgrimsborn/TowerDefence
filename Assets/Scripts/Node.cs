<<<<<<< HEAD
﻿ using UnityEngine;
=======
﻿using UnityEngine;
>>>>>>> 1c4152528858e10df41acd63d95ab7fba8aafd34
using UnityEngine.EventSystems;
using System.Collections;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public Vector3 positionOffset;

    [Header("Optional")]
	public GameObject turret;

	private Renderer rend;
	private Color startColor;

<<<<<<< HEAD
    BuildManager buildManager;

    void Start ()
=======
	BuildManager buildManager;

	void Start ()
>>>>>>> 1c4152528858e10df41acd63d95ab7fba8aafd34
	{
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;

<<<<<<< HEAD
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition ()
    {
        return transform.position + positionOffset;
    }

	void OnMouseDown ()
	{
        if (EventSystem.current.IsPointerOverGameObject())
            return;
=======
		buildManager = BuildManager.instance;
	}

	void OnMouseDown ()
	{
		if (EventSystem.current.IsPointerOverGameObject())
			return;

		if (buildManager.GetTurretToBuild() == null)
			return;

		if (turret != null)
		{
			Debug.Log("Can't build there! - TODO: Display on screen");
			return;
		}

		GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
		turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
	}
>>>>>>> 1c4152528858e10df41acd63d95ab7fba8aafd34

        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't build there! - TODO: Display on screen");
            return;
        }

        buildManager.BuildTurretOn(this);
    }
       
	void OnMouseEnter ()
	{
<<<<<<< HEAD
        if (EventSystem.current.IsPointerOverGameObject())
            return;    

        if (!buildManager.CanBuild)
            return;

        rend.material.color = hoverColor;
=======
		if (EventSystem.current.IsPointerOverGameObject())
			return;

		if (buildManager.GetTurretToBuild() == null)
			return;

		rend.material.color = hoverColor;
>>>>>>> 1c4152528858e10df41acd63d95ab7fba8aafd34
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
