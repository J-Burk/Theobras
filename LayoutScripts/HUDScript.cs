using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject EnemieValues;
    public GameObject CastValues;
    public GameObject EnemieCastValues;

    public GameObject MinionBorder;
    public GameObject BossBorder;
    public GameObject MaseterBorder;
    public GameObject TheobrasBorder;
    public GameObject EnemieTargetValues;

    public Image LifeBar;
    public Image ManaBar;
    public Image EnemieLifeBar;
    public Image EnemieTargetLifeBar;
    public Image CastBar;
    public Image EnemieCastBar;

    public Text PlayerLevel;
    public Text Life;
    public Text MaxLife;
    public Text Mana;
    public Text MaxMana;
    public Text EnemieName;
    public Text EnemieLevel;
    public Text EnemieTargetName;
    public Text EnemieAttackName;

    public float level;
    public float life;
    public float maxLife;
    public float mana;
    public float maxMana;
    public float enemieLife;
    public float maxEnemieLife;
    public float enemieLevel;
    public float enemieTargetLife;
    public float maxEnemieTargetLife;

    public float cast;
    public float maxCast;
    public float enemieCast;
    public float enemieMaxCast;

    public string enemieName;
    public string enemieTargetName;
    public string enemieAttackName;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        CastValues.SetActive(false);
        EnemieCastValues.SetActive(false);

    }

    void Update()
    {
        level = Player.GetComponent<PlayerValuesScript>().Level;
        life = Player.GetComponent<PlayerValuesScript>().life;
        maxLife = Player.GetComponent<PlayerValuesScript>().maxLife;
        mana = Player.GetComponent<PlayerValuesScript>().mana;
        maxMana = Player.GetComponent<PlayerValuesScript>().maxMana;
        cast = Player.GetComponent<PlayerControllerScript>().cast;
        maxCast = Player.GetComponent<PlayerControllerScript>().maxCast;

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
            switch (Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieNameScript>().Rank)
            {
                case "Master":
                    MinionBorder.SetActive(false);
                    MaseterBorder.SetActive(true);
                    BossBorder.SetActive(false);
                    TheobrasBorder.SetActive(false);
                    break;
                case "Minion":
                    MinionBorder.SetActive(true);
                    MaseterBorder.SetActive(false);
                    BossBorder.SetActive(false);
                    TheobrasBorder.SetActive(false);
                    break;
                case "Boss":
                    MinionBorder.SetActive(false);
                    MaseterBorder.SetActive(false);
                    BossBorder.SetActive(true);
                    TheobrasBorder.SetActive(false);
                    break;
                case "Theobras":
                    MinionBorder.SetActive(true);
                    MaseterBorder.SetActive(true);
                    BossBorder.SetActive(true);
                    TheobrasBorder.SetActive(true);
                    break;
            }
            maxEnemieLife = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().maxLife;
            enemieLife = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().life;
            enemieName = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieNameScript>().Name;
            enemieLevel = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().level;
            if (Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().enemieTarget == null)
            {
                EnemieTargetValues.SetActive(false);
            }
            else if (Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().enemieTarget != null)
            {
                maxEnemieTargetLife = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().enemieTarget.GetComponent<PlayerValuesScript>().maxLife;
                enemieTargetLife = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().enemieTarget.GetComponent<PlayerValuesScript>().life;
                enemieTargetName = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().enemieTarget.GetComponent<PlayerControllerScript>().Name;
                EnemieTargetValues.SetActive(true);
            }

            if (!Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().inCast)
            {
                EnemieCastValues.SetActive(false);
            }

            if (Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().inCast)
            {
                EnemieCastValues.SetActive(true);
                enemieCast = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().enemieCast;
                enemieMaxCast = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().enemieMaxCast;
                enemieAttackName = Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().AttackName;
            }
        }

        // CastDeSpawn
        if (Player.GetComponent<PlayerControllerScript>().inCast)
        {
            CastValues.SetActive(true);
        }
        else
        {
            CastValues.SetActive(false);
        }

        DisplayUpdate();
    }

    public void DisplayUpdate()
    {
        LifeBar.fillAmount = life / maxLife;
        ManaBar.fillAmount = mana / maxMana;
        Life.text = life.ToString();
        MaxLife.text = maxLife.ToString();
        Mana.text = mana.ToString();
        MaxMana.text = maxMana.ToString();
        PlayerLevel.text = level.ToString();
        CastBar.fillAmount = cast / maxCast;
        EnemieName.text = enemieName;
        EnemieLevel.text = enemieLevel.ToString();
        EnemieLifeBar.fillAmount = enemieLife / maxEnemieLife;
        EnemieTargetName.text = enemieTargetName;
        EnemieTargetLifeBar.fillAmount = enemieTargetLife / maxEnemieTargetLife;
        EnemieCastBar.fillAmount = enemieCast / enemieMaxCast;
        EnemieAttackName.text = enemieAttackName;
    }
}
