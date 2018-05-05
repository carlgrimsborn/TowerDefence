using UnityEngine;

public class Shop : MonoBehaviour {

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