using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerValuesScript : MonoBehaviour
{
    public int Level;
    public float maxLife;
    public float life;
    public float maxMana;
    public float mana;
    public float actEP;
    public float maxEP;

    public int LifePotion;
    public int ManaPotion;
    public int CastScroll;
    public int WalkScroll;
    public bool FirstWeapon;
    public bool SecondWeapon;
    public bool plusMana;

    void Start()
    {
        plusMana = true;
        Level = PlayerStaticValuesScript.Level;
        if (PlayerStaticValuesScript.PlayerClass == "Soldier")
        {
            PlayerStaticValuesScript.MaxLife = 2000 + (Level * 200);
            PlayerStaticValuesScript.MaxMana = 500 + (Level * 100);
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Magican")
        {
            PlayerStaticValuesScript.MaxLife = 1500 + (Level * 150);
            PlayerStaticValuesScript.MaxMana = 1500 + (Level * 150);
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Priest")
        {
            PlayerStaticValuesScript.MaxLife = 1000 + (Level * 100);
            PlayerStaticValuesScript.MaxMana = 2000 + (Level * 200);
        }        
        PlayerStaticValuesScript.Life = PlayerStaticValuesScript.MaxLife;
        PlayerStaticValuesScript.Mana = PlayerStaticValuesScript.MaxMana;

    }

    void Update()
    {
        if (PlayerStaticValuesScript.PlayerClass == "Soldier")
        {
            PlayerStaticValuesScript.MaxLife = 2000 + (Level * 200);
            PlayerStaticValuesScript.MaxMana = 500 + (Level * 100);
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Magican")
        {
            PlayerStaticValuesScript.MaxLife = 1500 + (Level * 150);
            PlayerStaticValuesScript.MaxMana = 1500 + (Level * 150);
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Priest")
        {
            PlayerStaticValuesScript.MaxLife = 1000 + (Level * 100);
            PlayerStaticValuesScript.MaxMana = 2000 + (Level * 200);
        }
        life = PlayerStaticValuesScript.Life;
        mana = PlayerStaticValuesScript.Mana;
        Level = PlayerStaticValuesScript.Level;
        maxLife = PlayerStaticValuesScript.MaxLife;
        maxMana = PlayerStaticValuesScript.MaxMana;
        actEP = PlayerStaticValuesScript.ActEP;
        maxEP = PlayerStaticValuesScript.Level * 100000;
        if (actEP > maxEP)
        {
            actEP -= maxEP;
            PlayerStaticValuesScript.Level++;
        }
        if (mana < maxMana && plusMana)
        {
            PlayerStaticValuesScript.Mana++;
            plusMana = false;
            Invoke("SetMana", 2);
        }

        LifePotion = PlayerStaticValuesScript.LifePotion;
        ManaPotion = PlayerStaticValuesScript.ManaPotion;
        CastScroll = PlayerStaticValuesScript.CastScroll;
        WalkScroll = PlayerStaticValuesScript.WalkScroll;
        FirstWeapon = PlayerStaticValuesScript.FirstWeapon;
        SecondWeapon = PlayerStaticValuesScript.SecondWeapon;
    }
    public void SetMana()
    {
        plusMana = true;
    }
}
