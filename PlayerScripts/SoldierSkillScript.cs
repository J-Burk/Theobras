using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierSkillScript : MonoBehaviour
{
    public float CoolDownHeavyHit;
    public float CoolDownSmalShield;
    public float CoolDownHardShield;
    public float CoolDownCrossHit;
    public float CoolDownSwordPower;
    public float CoolDownSwordHammer;
    public float CoolDownMadness;
    public float CoolDownMovePower;
    public float CoolDownSoldiersWill;

    public float ManaCosts;

    private void Start()
    {
        CoolDownHeavyHit = 0;
        CoolDownSmalShield = 0;
        CoolDownHardShield = 0;
        CoolDownCrossHit = 0;
        CoolDownSwordPower = 0;
        CoolDownSwordHammer = 0;
        CoolDownMadness = 0;
        CoolDownMovePower = 0;
        CoolDownSoldiersWill = 0;

    }
    private void Update()
    {
        if (CoolDownHeavyHit > 0)
        {
            CoolDownHeavyHit -= 1 * Time.deltaTime;
        }
        if (CoolDownSmalShield > 0)
        {
            CoolDownSmalShield -= 1 * Time.deltaTime;
        }
        if (CoolDownHardShield > 0)
        {
            CoolDownHardShield -= 1 * Time.deltaTime;
        }
        if (CoolDownCrossHit > 0)
        {
            CoolDownCrossHit -= 1 * Time.deltaTime;
        }
        if (CoolDownSwordPower > 0)
        {
            CoolDownSwordPower -= 1 * Time.deltaTime;
        }
        if (CoolDownSwordHammer > 0)
        {
            CoolDownSwordHammer -= 1 * Time.deltaTime;
        }
        if (CoolDownMadness > 0)
        {
            CoolDownMadness -= 1 * Time.deltaTime;
        }
        if (CoolDownMovePower > 0)
        {
            CoolDownMovePower -= 1 * Time.deltaTime;
        }
        if (CoolDownSoldiersWill > 0)
        {
            CoolDownSoldiersWill -= 1 * Time.deltaTime;
        }
    }
    public void HeavyHit()
    {
        if (CoolDownHeavyHit <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().damage = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().castHitAttack = true;
                CoolDownHeavyHit = 20;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    // Für spätere Multiplayer als Tankfähigkeit
    //public void Provoke()
    //{

    //}
    public void SmalShield()
    {
        if (CoolDownSmalShield <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().heal = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().healAttack = true;
                CoolDownSmalShield = 30;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void HardShield()
    {
        if (CoolDownHardShield <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().heal = 100;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().healAttack = true;
                CoolDownHardShield = 60;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void CrossHit()
    {
        if (CoolDownCrossHit <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().damage = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().castHitAttack = true;
                CoolDownCrossHit = 20;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void SwordPower()
    {
        if (CoolDownSwordPower <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().damage = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().castHitAttack = true;
                CoolDownSwordPower = 20;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void SwordHammer()
    {
        if (CoolDownSwordHammer <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().damage = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().castHitAttack = true;
                CoolDownSwordHammer = 30;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
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
                CoolDownMadness = 30;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void MovePower()
    {
        if (CoolDownMovePower <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().skillWalkBoost = true;
                GetComponent<PlayerControllerScript>().skillWalkBoostTimer = 10;
                CoolDownMovePower = 60;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void SoldiersWill()
    {
        if (CoolDownSoldiersWill <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().skillWalkBoost = true;
                GetComponent<PlayerControllerScript>().skillWalkBoostTimer = 15;
                CoolDownMovePower = 60;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
}
