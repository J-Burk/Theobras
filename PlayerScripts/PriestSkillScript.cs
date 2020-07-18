using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriestSkillScript : MonoBehaviour
{
    public float CoolDownSmite;
    public float CoolDownPowerSmash;
    public float CoolDownSmalBlessing;
    public float CoolDownBlessing;
    public float CoolDownHealingLight;
    public float CoolDownHealingWind;
    public float CoolDownCastPlus;
    public float CoolDownManaBlessing;
    public float CoolDownMadness;

    public float ManaCosts;

    private void Start()
    {
        CoolDownSmite = 0;
        CoolDownPowerSmash = 0;
        CoolDownSmalBlessing = 0;
        CoolDownBlessing = 0;
        CoolDownHealingLight = 0;
        CoolDownHealingWind = 0;
        CoolDownCastPlus = 0;
        CoolDownManaBlessing = 0;
        CoolDownMadness = 0;
    }
    private void Update()
    {
        if (CoolDownSmite > 0)
        {
            CoolDownSmite -= 1 * Time.deltaTime;
        }
        if (CoolDownPowerSmash > 0)
        {
            CoolDownPowerSmash -= 1 * Time.deltaTime;
        }
        if (CoolDownSmalBlessing > 0)
        {
            CoolDownSmalBlessing -= 1 * Time.deltaTime;
        }
        if (CoolDownBlessing > 0)
        {
            CoolDownBlessing -= 1 * Time.deltaTime;
        }
        if (CoolDownHealingLight > 0)
        {
            CoolDownHealingLight -= 1 * Time.deltaTime;
        }
        if (CoolDownHealingWind > 0)
        {
            CoolDownHealingWind -= 1 * Time.deltaTime;
        }
        if (CoolDownCastPlus > 0)
        {
            CoolDownCastPlus -= 1 * Time.deltaTime;
        }
        if (CoolDownManaBlessing > 0)
        {
            CoolDownManaBlessing -= 1 * Time.deltaTime;
        }
        if (CoolDownMadness > 0)
        {
            CoolDownMadness -= 1 * Time.deltaTime;
        }
    }
    public void Smite()
    {
        if (CoolDownSmite <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().damage = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().castHitAttack = true;
                CoolDownSmite = 5;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void PowerSmash()
    {
        if (CoolDownPowerSmash <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().damage = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().castHitAttack = true;
                CoolDownPowerSmash = 10;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void SmalBlessing()
    {
        if (CoolDownSmalBlessing <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().heal = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().healAttack = true;
                CoolDownSmalBlessing = 5;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void Blessing()
    {
        if (CoolDownBlessing <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().heal = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().healAttack = true;
                CoolDownBlessing = 15;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void HealingLight()
    {
        if (CoolDownHealingLight <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().heal = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().healAttack = true;
                CoolDownHealingLight = 20;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void HealingWind()
    {
        if (CoolDownHealingWind <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().heal = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().healAttack = true;
                CoolDownHealingWind = 20;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void CastPlus()
    {
        if (CoolDownCastPlus <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().skillCastBoost = true;
                GetComponent<PlayerControllerScript>().skillCastBoostTimer = 10;
                CoolDownCastPlus = 120;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void ManaBlessing()
    {
        if (CoolDownManaBlessing <= 0)
        {
            CoolDownManaBlessing = 60;
        }

    }
    public void Madness()
    {
        if (CoolDownMadness <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().madneess = true;
                CoolDownMadness = 60;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
}
