using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public GameObject GameChoice;
    public GameObject ClassChoice;
    public GameObject InsertName;
    public Text PlayerNameInput;
    void Start()
    {
        GameChoice.SetActive(true);
        ClassChoice.SetActive(false);
        InsertName.SetActive(false);
    }

    void Update()
    {
        
    }

    public void ToClassSelect()
    {
        GameChoice.SetActive(false);
        ClassChoice.SetActive(true);
        InsertName.SetActive(false);
    }
    public void Back()
    {
        GameChoice.SetActive(true);
        ClassChoice.SetActive(false);
    }
    public void SecondBack()
    {
        GameChoice.SetActive(false);
        ClassChoice.SetActive(true);
        InsertName.SetActive(false);
    }
    public void SetSoldier()
    {
        PlayerStaticValuesScript.PlayerClass = "Soldier";
        ClassChoice.SetActive(false);
        InsertName.SetActive(true);
    }
    public void SetPriest()
    {
        PlayerStaticValuesScript.PlayerClass = "Priest";
        ClassChoice.SetActive(false);
        InsertName.SetActive(true);
    }
    public void SetMagican()
    {
        PlayerStaticValuesScript.PlayerClass = "Magican";
        ClassChoice.SetActive(false);
        InsertName.SetActive(true);
    }
    public void StartGame()
    {
        PlayerStaticValuesScript.PlayerName = PlayerNameInput.text;
        PlayerStaticValuesScript.Level = 1;
        PlayerStaticValuesScript.ActEP = 0;
        PlayerStaticValuesScript.LifePotion = 0;
        PlayerStaticValuesScript.ManaPotion = 0;
        PlayerStaticValuesScript.CastScroll = 0;
        PlayerStaticValuesScript.WalkScroll = 0;
        PlayerStaticValuesScript.FirstWeapon = false;
        PlayerStaticValuesScript.SecondWeapon = false;
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
