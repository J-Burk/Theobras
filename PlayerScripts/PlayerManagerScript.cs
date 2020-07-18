using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerScript : MonoBehaviour
{
    public GameObject Soldier;
    public GameObject Priest;
    public GameObject Magican;

    void Awake()
    {
        if (PlayerStaticValuesScript.PlayerClass == "Soldier")
        {
            Soldier.SetActive(true);
            Priest.SetActive(false);
            Magican.SetActive(false);
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Priest")
        {
            Soldier.SetActive(false);
            Priest.SetActive(true);
            Magican.SetActive(false);
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Magican")
        {
            Soldier.SetActive(false);
            Priest.SetActive(false);
            Magican.SetActive(true);
        }
    }

    void Update()
    {

    }
}
