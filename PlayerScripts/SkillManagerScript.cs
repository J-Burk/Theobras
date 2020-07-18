using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManagerScript : MonoBehaviour
{
    public GameObject SoldierSkillList;
    public GameObject PriestSkillList;
    public GameObject MagicanSkillList;
    public GameObject QuickSoldierSkillList;
    public GameObject QuickPriestSkillList;
    public GameObject QuickMagicanSkillList;

    public GameObject SoldierSkill1;
    public GameObject SoldierSkill2;
    public GameObject SoldierSkill3;
    public GameObject SoldierSkill4;
    public GameObject SoldierSkill5;
    public GameObject PriestSkill1;
    public GameObject PriestSkill2;
    public GameObject PriestSkill3;
    public GameObject PriestSkill4;
    public GameObject PriestSkill5;
    public GameObject MagicanSkill1;
    public GameObject MagicanSkill2;
    public GameObject MagicanSkill3;
    public GameObject MagicanSkill4;
    public GameObject MagicanSkill5;

    public GameObject QuickSoldierSkill1;
    public GameObject QuickSoldierSkill2;
    public GameObject QuickSoldierSkill3;
    public GameObject QuickSoldierSkill4;
    public GameObject QuickSoldierSkill5;
    public GameObject QuickPriestSkill1;
    public GameObject QuickPriestSkill2;
    public GameObject QuickPriestSkill3;
    public GameObject QuickPriestSkill4;
    public GameObject QuickPriestSkill5;
    public GameObject QuickMagicanSkill1;
    public GameObject QuickMagicanSkill2;
    public GameObject QuickMagicanSkill3;
    public GameObject QuickMagicanSkill4;
    public GameObject QuickMagicanSkill5;

    void Start()
    {
        switch (PlayerStaticValuesScript.PlayerClass)
        {
            case "Soldier":
                SoldierSkillList.SetActive(true);
                PriestSkillList.SetActive(false);
                MagicanSkillList.SetActive(false);
                QuickSoldierSkillList.SetActive(true);
                QuickPriestSkillList.SetActive(false);
                QuickMagicanSkillList.SetActive(false);
                break;
            case "Priest":
                SoldierSkillList.SetActive(false);
                PriestSkillList.SetActive(true);
                MagicanSkillList.SetActive(false);
                QuickSoldierSkillList.SetActive(false);
                QuickPriestSkillList.SetActive(true);
                QuickMagicanSkillList.SetActive(false);
                break;
            case "Magican":
                SoldierSkillList.SetActive(false);
                PriestSkillList.SetActive(false);
                MagicanSkillList.SetActive(true);
                QuickSoldierSkillList.SetActive(false);
                QuickPriestSkillList.SetActive(false);
                QuickMagicanSkillList.SetActive(true);
                break;
        }

        SoldierSkill1.SetActive(false);
        SoldierSkill2.SetActive(false);
        SoldierSkill3.SetActive(false);
        SoldierSkill4.SetActive(false);
        SoldierSkill5.SetActive(false);
        PriestSkill1.SetActive(false);
        PriestSkill2.SetActive(false);
        PriestSkill3.SetActive(false);
        PriestSkill4.SetActive(false);
        PriestSkill5.SetActive(false);
        MagicanSkill1.SetActive(false);
        MagicanSkill2.SetActive(false);
        MagicanSkill3.SetActive(false);
        MagicanSkill4.SetActive(false);
        MagicanSkill5.SetActive(false);

        QuickSoldierSkill1.SetActive(false);
        QuickSoldierSkill2.SetActive(false);
        QuickSoldierSkill3.SetActive(false);
        QuickSoldierSkill4.SetActive(false);
        QuickSoldierSkill5.SetActive(false);
        QuickPriestSkill1.SetActive(false);
        QuickPriestSkill2.SetActive(false);
        QuickPriestSkill3.SetActive(false);
        QuickPriestSkill4.SetActive(false);
        QuickPriestSkill5.SetActive(false);
        QuickMagicanSkill1.SetActive(false);
        QuickMagicanSkill2.SetActive(false);
        QuickMagicanSkill3.SetActive(false);
        QuickMagicanSkill4.SetActive(false);
        QuickMagicanSkill5.SetActive(false);

    }

    void Update()
    {
        if (PlayerStaticValuesScript.PlayerClass == "Soldier")
        {
            if (PlayerStaticValuesScript.Level >= 5)
            {
                SoldierSkill1.SetActive(true);
                QuickSoldierSkill1.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 10)
            {
                SoldierSkill2.SetActive(true);
                QuickSoldierSkill2.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 15)
            {
                SoldierSkill3.SetActive(true);
                QuickSoldierSkill3.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 20)
            {
                SoldierSkill4.SetActive(true);
                QuickSoldierSkill4.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 25)
            {
                SoldierSkill5.SetActive(true);
                QuickSoldierSkill5.SetActive(true);
            }
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Priest")
        {
            if (PlayerStaticValuesScript.Level >= 5)
            {
                PriestSkill1.SetActive(true);
                QuickPriestSkill1.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 10)
            {
                PriestSkill2.SetActive(true);
                QuickPriestSkill2.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 15)
            {
                PriestSkill3.SetActive(true);
                QuickPriestSkill3.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 20)
            {
                PriestSkill4.SetActive(true);
                QuickPriestSkill4.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 25)
            {
                PriestSkill5.SetActive(true);
                QuickPriestSkill5.SetActive(true);
            }
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Magican")
        {
            if (PlayerStaticValuesScript.Level >= 5)
            {
                MagicanSkill1.SetActive(true);
                QuickMagicanSkill1.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 10)
            {
                MagicanSkill2.SetActive(true);
                QuickMagicanSkill2.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 15)
            {
                MagicanSkill3.SetActive(true);
                QuickMagicanSkill3.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 20)
            {
                MagicanSkill4.SetActive(true);
                QuickMagicanSkill4.SetActive(true);
            }
            if (PlayerStaticValuesScript.Level >= 25)
            {
                MagicanSkill5.SetActive(true);
                QuickMagicanSkill5.SetActive(true);
            }
        }
    }
}