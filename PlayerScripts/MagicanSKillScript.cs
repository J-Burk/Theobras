using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicanSKillScript : MonoBehaviour
{
    public GameObject FireBolt;
    public GameObject WaterBolt;
    public GameObject ThunderBolt;
    public GameObject IceShock;
    public GameObject FireExplosion;
    public GameObject IceIcle;

    public float CoolDownFirebolt;
    public float CoolDownWaterbolt;
    public float CoolDownThunderbolt;
    public float CoolDownIceshock;
    public float CoolDownFireexplosion;
    public float CoolDownWindFeets;
    public float CoolDownCastPower;
    public float CoolDownMagicAbsorb;
    public float CoolDownIceicle;

    public float ManaCosts;

    private void Start()
    {
        CoolDownFirebolt = 0;
        CoolDownWaterbolt = 0;
        CoolDownThunderbolt = 0;
        CoolDownIceshock = 0;
        CoolDownFireexplosion = 0;
        CoolDownWindFeets = 0;
        CoolDownCastPower = 0;
        CoolDownMagicAbsorb = 0;
        CoolDownIceicle = 0;
    }

    void Update()
    {
        if (CoolDownFirebolt > 0)
        {
            CoolDownFirebolt -= 1 * Time.deltaTime;
        }
        if (CoolDownWaterbolt > 0)
        {
            CoolDownWaterbolt -= 1 * Time.deltaTime;
        }
        if (CoolDownThunderbolt > 0)
        {
            CoolDownWaterbolt -= 1 * Time.deltaTime;
        }
        if (CoolDownIceshock > 0)
        {
            CoolDownIceshock -= 1 * Time.deltaTime;
        }
        if (CoolDownFireexplosion > 0)
        {
            CoolDownFireexplosion -= 1 * Time.deltaTime;
        }
        if (CoolDownWindFeets > 0)
        {
            CoolDownWindFeets -= 1 * Time.deltaTime;
        }
        if (CoolDownCastPower > 0)
        {
            CoolDownCastPower -= 1 * Time.deltaTime;
        }
        if (CoolDownMagicAbsorb > 0)
        {
            CoolDownMagicAbsorb -= 1 * Time.deltaTime;
        }
        if (CoolDownIceicle > 0)
        {
            CoolDownIceicle -= 1 * Time.deltaTime;
        }
    }
    public void Firebolt()
    {
        if (CoolDownFirebolt <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().AktSummonItem = FireBolt;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().summonAttack = true;
                GetComponent<PlayerControllerScript>().SummonPosition = transform.position;
                CoolDownFirebolt = 5;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void Waterbolt()
    {
        if (CoolDownWaterbolt <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().AktSummonItem = WaterBolt;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().summonAttack = true;
                GetComponent<PlayerControllerScript>().SummonPosition = transform.position;
                CoolDownWaterbolt = 5;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void Thunderbolt()
    {
        if (CoolDownThunderbolt <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().AktSummonItem = ThunderBolt;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().summonAttack = true;
                GetComponent<PlayerControllerScript>().SummonPosition = transform.position;
                CoolDownThunderbolt = 5;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void Iceshock()
    {
        if (CoolDownIceshock <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().AktSummonItem = IceShock;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().summonAttack = true;
                GetComponent<PlayerControllerScript>().SummonPosition = GetComponent<PlayerControllerScript>().Target.transform.position;
                CoolDownIceshock = 5;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void Fireexplosion()
    {
        if (CoolDownFireexplosion <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().AktSummonItem = FireExplosion;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().summonAttack = true;
                GetComponent<PlayerControllerScript>().SummonPosition = GetComponent<PlayerControllerScript>().Target.transform.position;
                CoolDownFireexplosion = 15;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void WindFeets()
    {
        if (CoolDownWindFeets <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().skillWalkBoost = true;
                GetComponent<PlayerControllerScript>().skillWalkBoostTimer = 10;
                CoolDownWindFeets = 60;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void CastPower()
    {
        if (CoolDownCastPower <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().skillCastBoost = true;
                GetComponent<PlayerControllerScript>().skillCastBoostTimer = 10;
                CoolDownCastPower = 120;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void MagicAbsorb()
    {
        if (CoolDownMagicAbsorb <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().heal = 50;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().healAttack = true;
                CoolDownMagicAbsorb = 60;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
    public void Iceicle()
    {
        if (CoolDownIceicle <= 0)
        {
            ManaCosts = 10;
            if (ManaCosts < GetComponent<PlayerValuesScript>().mana)
            {
                GetComponent<PlayerControllerScript>().cast = 0;
                GetComponent<PlayerControllerScript>().maxCast = 5;
                GetComponent<PlayerControllerScript>().AktSummonItem = IceIcle;
                GetComponent<PlayerControllerScript>().inCast = true;
                GetComponent<PlayerControllerScript>().summonAttack = true;
                GetComponent<PlayerControllerScript>().SummonPosition = new Vector3(GetComponent<PlayerControllerScript>().Target.transform.position.x, (GetComponent<PlayerControllerScript>().Target.transform.position.y +10), GetComponent<PlayerControllerScript>().Target.transform.position.z);
                CoolDownIceicle = 30;
                PlayerStaticValuesScript.Mana -= ManaCosts;
            }
        }
    }
}
