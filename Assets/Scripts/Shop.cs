using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;

    void Start()
    {

        buildManager = BuildManager.instance;

    }

    public void PurchaseStandardTurret()
    {

        Debug.Log("standardTurret");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);

    }

    public void PurchaseMissileLauncher()
    {

        Debug.Log("missilskjutare vald");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);

    }
}