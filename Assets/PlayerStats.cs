using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    //static data will be carried on to one scene from another
    public static int Money;
    public int startMoney = 400;

    private void Start()
    {
        Money = startMoney;
    }
}
