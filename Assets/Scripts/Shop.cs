using UnityEngine;

public class Shop : MonoBehaviour {

<<<<<<< HEAD
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;


    BuildManager buildManager;

    void Start()
    {

        buildManager = BuildManager.instance;

    }

    public void SelectStandardTurret()
    {

        Debug.Log("standardTurret");
        buildManager.SelectTurretToBuild(standardTurret);

    }

    public void SelectMissileLauncher()
    {

        Debug.Log("missilskjutare vald");
        buildManager.SelectTurretToBuild(missileLauncher);

    }
}
=======
	BuildManager buildManager;

	void Start () {

		buildManager = BuildManager.instance;

	}

	public void PurchaseStandardTurret () {

		Debug.Log("standardTurret");
		buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);

	}

	public void PurchaseMissileLauncher () {

		Debug.Log("missilskjutare vald");
		buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);

	}
}
>>>>>>> 1c4152528858e10df41acd63d95ab7fba8aafd34
