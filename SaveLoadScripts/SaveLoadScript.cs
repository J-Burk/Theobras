using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoadScript : MonoBehaviour
{
    public int Level;
    public float ActEP;
    public string PlayerClass;
    public string PlayerName;
    public int LifePotion;
    public int ManaPotion;
    public int CastScroll;
    public int WalkScroll;
    public bool FirstWeapon;
    public bool SecondWeapon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Level = PlayerStaticValuesScript.Level;
        ActEP = PlayerStaticValuesScript.ActEP;
        PlayerClass = PlayerStaticValuesScript.PlayerClass;
        PlayerName = PlayerStaticValuesScript.PlayerName;
        LifePotion = PlayerStaticValuesScript.LifePotion;
        ManaPotion = PlayerStaticValuesScript.ManaPotion;
        CastScroll = PlayerStaticValuesScript.CastScroll;
        WalkScroll = PlayerStaticValuesScript.WalkScroll;
        FirstWeapon = PlayerStaticValuesScript.FirstWeapon;
        SecondWeapon = PlayerStaticValuesScript.SecondWeapon;
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Levelkey", 1);
        PlayerPrefs.SetFloat("ActEPKey", 0);
        PlayerPrefs.SetString("PlayerClassKey", null);
        PlayerPrefs.SetString("PlayerNameKey", null);
        PlayerPrefs.SetInt("LifePotionKey", 0);
        PlayerPrefs.SetInt("ManaPotionKey", 0);
        PlayerPrefs.SetInt("CastScrollKey", 0);
        PlayerPrefs.SetInt("WalkScrollKey", 0);
    }
    public void Load()
    {
        PlayerStaticValuesScript.Level = PlayerPrefs.GetInt("Levelkey", 1);
        PlayerStaticValuesScript.ActEP = PlayerPrefs.GetFloat("ActEPKey", 0);
        PlayerStaticValuesScript.PlayerClass = PlayerPrefs.GetString("PlayerClassKey", null);
        PlayerStaticValuesScript.PlayerName = PlayerPrefs.GetString("PlayerNameKey", null);
        PlayerStaticValuesScript.LifePotion = PlayerPrefs.GetInt("LifePotionKey", 0);
        PlayerStaticValuesScript.ManaPotion = PlayerPrefs.GetInt("ManaPotionKey", 0);
        PlayerStaticValuesScript.CastScroll = PlayerPrefs.GetInt("CastScrollKey", 0);
        PlayerStaticValuesScript.WalkScroll = PlayerPrefs.GetInt("WalkScrollKey", 0);


        SceneManager.LoadScene(1);
    }
}
