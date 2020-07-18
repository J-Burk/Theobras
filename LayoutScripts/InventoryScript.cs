using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    public GameObject Player;

    public GameObject LifePotion;
    public GameObject ManaPotion;
    public GameObject CastScroll;
    public GameObject WalkScroll;
    public GameObject Weaapon1;
    public GameObject Weapon2;

    public int lifePotionAmount;
    public int manaPotionAmount;
    public int castScrollAmount;
    public int walkScrollAmount;

    public Text LifePotionAmount;
    public Text ManaPotionAmount;
    public Text CastScrollAmount;
    public Text WalkScrollAmount;

    public GameObject SoldierWeaponOne;
    public GameObject SoldierWeaponTwo;
    public GameObject SoldierWeaponThree;
    public GameObject PriestWeaponOne;
    public GameObject PriestWeaponTwo;
    public GameObject PriestWeaponThree;
    public GameObject MagicanWeaponOne;
    public GameObject MagicanWeaponTwo;
    public GameObject MagicanWeaponThree;

    public Image soldierWeaponOne;
    public Image soldierWeaponTwo;
    public Image priestWeaponOne;
    public Image priestWeaponTwo;
    public Image magicanWeaponOne;
    public Image magicanWeaponTwo;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (PlayerStaticValuesScript.PlayerClass == "Soldier")
        {
            SoldierWeaponOne.SetActive(true);
            SoldierWeaponTwo.SetActive(false);
            SoldierWeaponThree.SetActive(false);
            soldierWeaponOne.enabled = true;
            soldierWeaponTwo.enabled = true;
            priestWeaponOne.enabled = false;
            priestWeaponTwo.enabled = false;
            magicanWeaponOne.enabled = false;
            magicanWeaponTwo.enabled = false;
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Priest")
        {
            PriestWeaponOne.SetActive(true);
            PriestWeaponTwo.SetActive(false);
            PriestWeaponThree.SetActive(false);
            soldierWeaponOne.enabled = false;
            soldierWeaponTwo.enabled = false;
            priestWeaponOne.enabled = true;
            priestWeaponTwo.enabled = true;
            magicanWeaponOne.enabled = false;
            magicanWeaponTwo.enabled = false;
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Magican")
        {
            MagicanWeaponOne.SetActive(true);
            MagicanWeaponTwo.SetActive(false);
            MagicanWeaponThree.SetActive(false);
            soldierWeaponOne.enabled = false;
            soldierWeaponTwo.enabled = false;
            priestWeaponOne.enabled = false;
            priestWeaponTwo.enabled = false;
            magicanWeaponOne.enabled = true;
            magicanWeaponTwo.enabled = true;
        }
    }

void Update()
    {
        if (PlayerStaticValuesScript.LifePotion < 1)
        {
            LifePotion.SetActive(false);
        }
        else
        {
            LifePotion.SetActive(true);
        }
        if (PlayerStaticValuesScript.ManaPotion < 1)
        {
            ManaPotion.SetActive(false);
        }
        else
        {
            ManaPotion.SetActive(true);
        }
        if (PlayerStaticValuesScript.CastScroll < 1)
        {
            CastScroll.SetActive(false);
        }
        else
        {
            CastScroll.SetActive(true);
        }
        if (PlayerStaticValuesScript.WalkScroll < 1)
        {
            WalkScroll.SetActive(false);
        }
        else
        {
            WalkScroll.SetActive(true);
        }
        if (!PlayerStaticValuesScript.FirstWeapon)
        {
            Weaapon1.SetActive(false);
        }
        else
        {
            Weaapon1.SetActive(true);
        }
        if (!PlayerStaticValuesScript.SecondWeapon)
        {
            Weapon2.SetActive(false);
        }
        else
        {
            Weapon2.SetActive(true);
        }

        // Übergabe der Anzahl der Gegenstände
        lifePotionAmount = PlayerStaticValuesScript.LifePotion;
        manaPotionAmount = PlayerStaticValuesScript.ManaPotion;
        castScrollAmount = PlayerStaticValuesScript.CastScroll;
        walkScrollAmount = PlayerStaticValuesScript.WalkScroll;
        DisplayUpdate();

        if (SoldierWeaponOne || PriestWeaponOne || MagicanWeaponOne)
        {
            Player.GetComponent<PlayerControllerScript>().plusDamage = 0;
        }
        if (SoldierWeaponTwo || PriestWeaponTwo || MagicanWeaponTwo)
        {
            Player.GetComponent<PlayerControllerScript>().plusDamage = 100;
        }
        if (SoldierWeaponThree || PriestWeaponThree || MagicanWeaponThree)
        {
            Player.GetComponent<PlayerControllerScript>().plusDamage = 200;
        }
    }

    public void DisplayUpdate()
    {
        LifePotionAmount.text = lifePotionAmount.ToString();
        ManaPotionAmount.text = manaPotionAmount.ToString();
        CastScrollAmount.text = castScrollAmount.ToString();
        WalkScrollAmount.text = walkScrollAmount.ToString();
    }

    public void UseLifePotion()
    {
        PlayerStaticValuesScript.LifePotion--;
        if (PlayerStaticValuesScript.Life + 1000 <= PlayerStaticValuesScript.MaxLife)
        {
            PlayerStaticValuesScript.Life += 1000;
        }
        else
        {
            PlayerStaticValuesScript.Life = PlayerStaticValuesScript.MaxLife;
        }
    }
    public void UseManaPotion()
    {
        PlayerStaticValuesScript.ManaPotion--;
        if (PlayerStaticValuesScript.Mana + 1000 <= PlayerStaticValuesScript.MaxMana)
        {
            PlayerStaticValuesScript.Mana += 1000;
        }
        else
        {
            PlayerStaticValuesScript.Mana = PlayerStaticValuesScript.MaxMana;
        }
    }
    public void UseCastScroll()
    {
        Player.GetComponent<PlayerControllerScript>().scrollCastBoost = true;
        Player.GetComponent<PlayerControllerScript>().scrollCastBoostTimer = 300;
        PlayerStaticValuesScript.CastScroll--;
    }
    public void UseWalkScroll()
    {
        Player.GetComponent<PlayerControllerScript>().scrollWalkBoost = true;
        Player.GetComponent<PlayerControllerScript>().scrollWalkBoostTimer = 300;
        PlayerStaticValuesScript.WalkScroll--;
    }
    public void UseWeapon1()
    {
        if (PlayerStaticValuesScript.PlayerClass == "Soldier")
        {
            if (SoldierWeaponOne.activeInHierarchy || SoldierWeaponThree.activeInHierarchy)
            {
                SoldierWeaponOne.SetActive(false);
                SoldierWeaponTwo.SetActive(true);
                SoldierWeaponThree.SetActive(false);
            }
            else if (SoldierWeaponTwo.activeInHierarchy)
            {
                SoldierWeaponOne.SetActive(true);
                SoldierWeaponTwo.SetActive(false);
                SoldierWeaponThree.SetActive(false);
            }
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Priest")
        {
            if (PriestWeaponOne.activeInHierarchy || PriestWeaponThree.activeInHierarchy)
            {
                PriestWeaponOne.SetActive(false);
                PriestWeaponTwo.SetActive(true);
                PriestWeaponThree.SetActive(false);
            }
            else if (PriestWeaponTwo.activeInHierarchy)
            {
                PriestWeaponOne.SetActive(true);
                PriestWeaponTwo.SetActive(false);
                PriestWeaponThree.SetActive(false);
            }
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Magican")
        {
            if (MagicanWeaponOne.activeInHierarchy || MagicanWeaponThree.activeInHierarchy)
            {
                MagicanWeaponOne.SetActive(false);
                MagicanWeaponTwo.SetActive(true);
                MagicanWeaponThree.SetActive(false);
            }
            else if (MagicanWeaponTwo.activeInHierarchy)
            {
                MagicanWeaponOne.SetActive(true);
                MagicanWeaponTwo.SetActive(false);
                MagicanWeaponThree.SetActive(false);
            }
        }
    }
    public void UseWeapon2()
    {
        if (PlayerStaticValuesScript.PlayerClass == "Soldier")
        {
            if (SoldierWeaponOne.activeInHierarchy || SoldierWeaponTwo.activeInHierarchy)
            {
                SoldierWeaponOne.SetActive(false);
                SoldierWeaponTwo.SetActive(false);
                SoldierWeaponThree.SetActive(true);
            }
            else if(SoldierWeaponThree.activeInHierarchy)
            {
                SoldierWeaponOne.SetActive(true);
                SoldierWeaponTwo.SetActive(false);
                SoldierWeaponThree.SetActive(false);
            }
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Priest")
        {
            if (PriestWeaponOne.activeInHierarchy || PriestWeaponTwo.activeInHierarchy)
            {
                PriestWeaponOne.SetActive(false);
                PriestWeaponTwo.SetActive(false);
                PriestWeaponThree.SetActive(true);
            }
            else if (PriestWeaponThree.activeInHierarchy)
            {
                PriestWeaponOne.SetActive(true);
                PriestWeaponTwo.SetActive(false);
                PriestWeaponThree.SetActive(false);
            }
        }
        else if (PlayerStaticValuesScript.PlayerClass == "Magican")
        {
            if (MagicanWeaponOne.activeInHierarchy || MagicanWeaponTwo.activeInHierarchy)
            {
                MagicanWeaponOne.SetActive(false);
                MagicanWeaponTwo.SetActive(false);
                MagicanWeaponThree.SetActive(true);
            }
            else if(MagicanWeaponThree.activeInHierarchy)
            {
                MagicanWeaponOne.SetActive(true);
                MagicanWeaponTwo.SetActive(false);
                MagicanWeaponThree.SetActive(false);
            }
        }
    }

}
