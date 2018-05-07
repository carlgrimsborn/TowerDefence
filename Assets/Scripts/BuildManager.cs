using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    private TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }

    public void BuildTurretOn (Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("You can't afford that");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        Debug.Log("Turret was built. Money left: " + PlayerStats.Money);
    }

    public void SelectTurretToBuild (TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}    
=======
public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	void Awake ()
	{
		if (instance != null)
		{
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}

	public GameObject standardTurretPrefab;
	public GameObject missileLauncherPrefab;

	private GameObject turretToBuild;

	public GameObject GetTurretToBuild ()
	{
		return turretToBuild;
	}

	public void SetTurretToBuild (GameObject turret)
	{
		turretToBuild = turret;
	}
}
>>>>>>> 1c4152528858e10df41acd63d95ab7fba8aafd34
