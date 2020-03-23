using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject EnemieValues;
    public GameObject CastValues;

    public Image LifeBar;
    public Image ManaBar;
    public Image EnemieLifeBar;
    public Image EnemieTargetLifeBar;
    public Image CastBar;
    public Image MinionBorder;
    public Image BossBorder;
    public Image MaseterBorder;
    public Image TheobrasBorder;

    public Text PlayerLevel;
    public Text EnemieName;
    public Text EnemieTargetName;


    public float life;
    public float maxLife;
    public float mana;
    public float maxMana;
    public float enemieLife;
    public float maxEnemieLife;
    public float enemieTargetLife;
    public float maxEnemieTargetLife;

    public float cast;
    public float maxCast;

    public string enemieName;
    public string enemieTargetName;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        maxLife = 100;
        maxMana = 100;
        CastValues.SetActive(false);
    }

    void Update()
    {
        life = Player.GetComponent<PlayerValuesScript>().life;
        mana = Player.GetComponent<PlayerValuesScript>().mana;
        cast += 1 * Time.deltaTime;
        
        if (Player.GetComponent<PlayerControllerScript>().Target == null)
        {
            EnemieValues.SetActive(false);
        }
        else if(Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>() == null)
        {
            EnemieValues.SetActive(false);
        }
        else if (Player.GetComponent<PlayerControllerScript>().Target != null)
        {
            EnemieValues.SetActive(true);
            maxEnemieLife = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().maxLife;
            enemieLife = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().life;
            enemieName = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieNameScript>().Name;
            maxEnemieTargetLife = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().enemieTarget.GetComponent<PlayerValuesScript>().maxLife;
            enemieTargetLife = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().enemieTarget.GetComponent<PlayerValuesScript>().life;
            enemieTargetName = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().enemieTarget.GetComponent<PlayerControllerScript>().Name;
        }

        // CastDeSpawn
        if (cast >= maxCast)
        {
            CastValues.SetActive(false);
        }
        DisplayUpdate();
    }

    public void DisplayUpdate()
    {
        LifeBar.fillAmount = life / maxLife;
        ManaBar.fillAmount = mana / maxMana;
        EnemieLifeBar.fillAmount = enemieLife / maxEnemieLife;
        CastBar.fillAmount = cast / maxCast;
        EnemieName.text = enemieName;
        EnemieTargetName.text = enemieTargetName;
        EnemieTargetLifeBar.fillAmount = enemieTargetLife / maxEnemieTargetLife;
    }

    public void Cast()
    {            
        cast = 0;
        if (cast <= maxCast)
        {        
            CastValues.SetActive(true);
        }
    }
}
