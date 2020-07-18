using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveValuesScript 
{
    public int Level { get; set; }
    public float ActEP { get; set; }
    public string PlayerClass { set; get; }
    public string PlayerName { set; get; }
    public int LifePotion { get; set; }
    public int ManaPotion { get; set; }
    public int CastScroll { get; set; }
    public int WalkScroll { get; set; }
    public bool FirstWeapon { get; set; }
    public bool SecondWeapon { get; set; }

    public SaveValuesScript()
    {

    }
    public SaveValuesScript(int level, float actEP, string playerClass, string playerName, int lifePotion, int manaPotion, int castScroll, int walkScroll, bool firstWeapon, bool secondWeapon)
    {
        Level = level;
        ActEP = actEP;
        PlayerClass = playerClass;
        PlayerName = playerName;
        LifePotion = lifePotion;
        ManaPotion = manaPotion;
        CastScroll = castScroll;
        WalkScroll = walkScroll;
        FirstWeapon = firstWeapon;
        SecondWeapon = secondWeapon;
    }

}
