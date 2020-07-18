using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemieAlphaScript : MonoBehaviour
{
    //GameObject TestPlayer;
    public GameObject[] Players;
    public Transform enemieTarget;
    public GameObject CastParticle;
    public GameObject AktSummonItem;
    
    //Beschwoerungsgegenstaende für Angriffe
    public GameObject Meteor;
    public GameObject Hellflame;
    //Beschwoerungsort der Angriffe
    public Vector3 AttackSpawn;

    Animator enemieAnimator;
    public AudioSource EnemieAudioSource;
    public AudioClip SpiderSound;
    public AudioClip GoblinSound;
    public AudioClip SkeletonSound;
    public AudioClip WizzardSound;
    public AudioClip TheobrasSound;
    public AudioClip HeavyTheobrasSound;

    public string Name;
    public string AttackName;

    public float level;
    public float maxLife;
    public float life;
    public float distance;
    public float attackDistance;
    public float followDistance;
    public float maxDistance;
    public float moveSpeed;
    public float rotationSpeed;
    public float castSpeed;
    public float enemieCast;
    public float enemieMaxCast;
    public float damage;
    public float attack;
    public float heal;
    public float madnessTimer;
    public float dropRandomizer;

    public bool die;
    public bool walk;
    public bool inMove;
    public bool inCast;
    public bool autoHit;
    public bool hitAttack;
    public bool healAttack;
    public bool summonAttack;
    public bool madneess;
    public bool givenEP;
    public bool givenDrop;

    public bool bossSpecielUsed;
    public bool MasterSpeciel1Used;
    public bool MasterSpeciel2Used;
    public bool TheobrasSpeciel1Used;
    public bool TheobrasSpeciel2Used;
    public bool TheobrasSpeciel3Used;
    public bool TheobrasSpeciel4Used;

    public int aktAtk;
    void Start()
    {
        Players = GameObject.FindGameObjectsWithTag("Player");
        EnemieAudioSource = GetComponent<AudioSource>();
        enemieTarget = null;
        aktAtk = 1;
        castSpeed = 1;
        enemieCast = 0;
        madnessTimer = 0;
        hitAttack = false;
        healAttack = false;
        summonAttack = false;
        givenEP = false;
        givenDrop = false;

        // AblaufValues
        bossSpecielUsed = false;
        MasterSpeciel1Used = false;
        MasterSpeciel2Used = false;
        TheobrasSpeciel1Used = false;
        TheobrasSpeciel2Used = false;
        TheobrasSpeciel3Used = false;
        TheobrasSpeciel4Used = false;


        //Levelbestimmung durch Rasse und Rang
        if (GetComponent<EnemieNameScript>().Class == "Spider")
        {
            if (GetComponent<EnemieNameScript>().Rank == "Minion")
            {
                level = Random.Range(1, 5);
                attackDistance = 3;
                followDistance = 15;
            }
            else if (GetComponent<EnemieNameScript>().Rank == "Boss")
            {
                level = Random.Range(5, 10);
                attackDistance = 3;
                followDistance = 20;
            }
            else if (GetComponent<EnemieNameScript>().Rank == "Master")
            {
                level = 15;
                attackDistance = 3;
                followDistance = 20;
            }
        }
        else if (GetComponent<EnemieNameScript>().Class == "Goblin")
        {
            if (GetComponent<EnemieNameScript>().Rank == "Minion")
            {
                level = Random.Range(15, 20);
                attackDistance = 5;
                followDistance = 15;
            }
            else if (GetComponent<EnemieNameScript>().Rank == "Boss")
            {
                level = Random.Range(20, 25);
                attackDistance = 10;
                followDistance = 20;
            }
            else if (GetComponent<EnemieNameScript>().Rank == "Master")
            {
                level = 30;
                attackDistance = 15;
                followDistance = 25;
            }
        }
        else if (GetComponent<EnemieNameScript>().Class == "Skeleton")
        {
            if (GetComponent<EnemieNameScript>().Rank == "Minion")
            {
                level = Random.Range(5, 10);
                attackDistance = 3;
                followDistance = 15;
            }
            else if (GetComponent<EnemieNameScript>().Rank == "Boss")
            {
                level = Random.Range(10, 15);
                attackDistance = 5;
                followDistance = 20;
            }
            else if (GetComponent<EnemieNameScript>().Rank == "Master")
            {
                level = 20;
                attackDistance = 5;
                followDistance = 20;
            }
        }
        else if (GetComponent<EnemieNameScript>().Class == "Wizzard")
        {
            if (GetComponent<EnemieNameScript>().Rank == "Minion")
            {
                level = Random.Range(20, 25);
                attackDistance = 10;
                followDistance = 15;
            }
            else if (GetComponent<EnemieNameScript>().Rank == "Boss")
            {
                level = Random.Range(25, 30);
                attackDistance = 10;
                followDistance = 20;
            }
            else if (GetComponent<EnemieNameScript>().Rank == "Master")
            {
                level = 40;
                attackDistance = 10;
                followDistance = 20;
            }
        }
        else if (GetComponent<EnemieNameScript>().Class == "God")
        {
            //Master Theobras Values
            level = 50;
            attackDistance = 5;
            followDistance = 25;
        }

        // Lebenszuweisung nach Typ
        maxLife = level * 500;
        life = maxLife;
        attack = level * 2;

        //Restliche Valuebestimmung
        if (CastParticle != null)
        {
            CastParticle.SetActive(false);
        }
        Name = GetComponent<EnemieNameScript>().Name;
        if (GetComponent<EnemieNameScript>().Class == "God") 
        {
            moveSpeed = 5;
        }
        else
        {
            moveSpeed = 2;
        }
        rotationSpeed = 5;
        walk = false;
        die = false;
        inMove = false;

        // TestValues für ein SPieler Target
        //TestPlayer = GameObject.FindGameObjectWithTag("Player");
        //enemieTarget = GameObject.FindGameObjectWithTag("Player").transform;
        enemieAnimator = gameObject.GetComponent<Animator>();

        //Audiozuweisung Vorab
        if (GetComponent<EnemieNameScript>().Class == "Spider")
        {
            EnemieAudioSource.clip = SpiderSound;
        }
        else if (GetComponent<EnemieNameScript>().Class == "Goblin")
        {
            EnemieAudioSource.clip = GoblinSound;
        }
        else if (GetComponent<EnemieNameScript>().Class == "Skeleton")
        {
            EnemieAudioSource.clip = SkeletonSound;
        }
        else if (GetComponent<EnemieNameScript>().Class == "Wizzard")
        {
            EnemieAudioSource.clip = WizzardSound;
        }
        else if (GetComponent<EnemieNameScript>().Class == "God")
        {
            EnemieAudioSource.clip = TheobrasSound;
        }

    }

    void Update()
    {
        if (enemieTarget == null)
        {
            // Liste erstellen der Spieler und Prüfen welcher Spieler in Reichweite ist und diesen anvisieren
            for (int i = 0; i < Players.Length; i++)
            {
                Transform Player = Players[i].gameObject.transform;
                if (Vector3.Distance(Player.position, transform.position) < followDistance)
                {
                    enemieTarget = Player;
                }
            }
        }
        if (enemieAnimator != null)
        {
            enemieAnimator.SetBool("die", die);
            enemieAnimator.SetBool("walk", walk);
        }        
        
        //AngriffsMuster
        if (GetComponent<EnemieNameScript>().Rank == "Boss" && life < (maxLife / 2) && !bossSpecielUsed)
        {
            aktAtk = 2;
            bossSpecielUsed = true;
        }
        if (GetComponent<EnemieNameScript>().Rank == "Master" && life < (maxLife / 2) && !MasterSpeciel1Used)
        {
            aktAtk = 2;
            MasterSpeciel1Used = true;
        }
        if (GetComponent<EnemieNameScript>().Rank == "Master" && life < (maxLife / 3) && !MasterSpeciel2Used)
        {
            aktAtk = 3;
            MasterSpeciel2Used = true;
        }
        if (GetComponent<EnemieNameScript>().Rank == "Theobras")
        {
            if (life < (maxLife - (maxLife / 4)))
            {
                if (!TheobrasSpeciel1Used)
                {
                    aktAtk = 2;
                    TheobrasSpeciel1Used = true;
                }
            }
            if (life < (maxLife / 2))
            {
                if (!TheobrasSpeciel2Used)
                {
                    aktAtk = 3;
                    TheobrasSpeciel2Used = true;
                }
            }
            if(life < (maxLife / 4))
            {
                if (!TheobrasSpeciel3Used)
                {
                    aktAtk = 4;
                    TheobrasSpeciel3Used = true;

                }
            }
            if (life < (maxLife / 5))
            {
                if (!TheobrasSpeciel4Used)
                {
                    aktAtk = 5;
                    TheobrasSpeciel4Used = true;
                }
            }
        }


        if (enemieTarget != null)
        {
            distance = Vector3.Distance(enemieTarget.position, transform.position);
            if (enemieTarget.GetComponent<PlayerControllerScript>().die)
            {
                enemieTarget = null;
            }
            if (die)
            {
                enemieTarget = null;
            }
        }

        if (!die)
        {
            RangeChecker();
            if (inCast)
            {
                enemieCast += 1 * Time.deltaTime * castSpeed;
                CastParticle.SetActive(true);
                CastAttack();
            }
            if (autoHit)
            {
                enemieCast += 1 * Time.deltaTime;
                Hit();
            }
        }
        // Ablauf bei Tod
        if (life <= 0)
        {
            // DropManager
            dropRandomizer = Random.Range(1, 100);
            if (!givenEP)
            {
                PlayerStaticValuesScript.ActEP += level * 1000;
                givenEP = true;
            }
            if (!givenDrop)
            {
                if (dropRandomizer < 21)
                {
                    PlayerStaticValuesScript.LifePotion++;
                }
                else if (dropRandomizer > 20 && dropRandomizer < 35)
                {
                    PlayerStaticValuesScript.ManaPotion++;
                }
                else if (dropRandomizer > 40 && dropRandomizer < 60)
                {
                    PlayerStaticValuesScript.CastScroll++;
                }
                else if (dropRandomizer > 60 && dropRandomizer < 80)
                {
                    PlayerStaticValuesScript.WalkScroll++;
                }
                else if (dropRandomizer == 85)
                {
                    PlayerStaticValuesScript.FirstWeapon = true;
                }
                else if (dropRandomizer == 95)
                {
                    PlayerStaticValuesScript.SecondWeapon = true;
                }
                givenDrop = true;
            }
            Invoke("Die", 5);
            die = true;
        }

        //Madnessefekt vom Spieler ausgehend, verlangsamt den Cast
        if (madneess)
        {
            castSpeed = 0.8f;
            Invoke("MadnessDelete", 30);
            madnessTimer -= 1 * Time.deltaTime; 
            if (madnessTimer <= 0)
            {
                madnessTimer = 30;
            }
        }
        else if(!madneess)
        {
            madnessTimer = 0;
        }


        //Monster unter der Karte gelöscht
        if (gameObject.transform.position.y <= -100)
        {
            Destroy(gameObject);
        }
    }

    public void RangeChecker()
    {
        if (enemieTarget != null)
        {
            if( distance <= followDistance && distance > attackDistance && !inMove && !die && !inCast)
            {            
                walk = true;
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(enemieTarget.position - transform.position), rotationSpeed * Time.deltaTime);
                transform.position += transform.forward *Time.deltaTime * moveSpeed ;
            }
            else if (distance <= attackDistance && !inMove && !die)
            {            
                walk = false;
                if (!inCast && !autoHit)
                {
                    switch (aktAtk)
                    {
                        case 1:
                            // Autohit
                            enemieCast = 0;
                            enemieMaxCast = 3;
                            damage = 10;
                            autoHit = true;
                            break;
                        case 2:
                            //PowerStrike();
                            enemieCast = 0;
                            enemieMaxCast = 5;
                            damage = 50;
                            inCast = true;
                            hitAttack = true;
                            AttackName = "PowerStrike";
                            break;
                        case 3:
                            //MeteorStrike();
                            enemieCast = 0;
                            enemieMaxCast = 7;
                            inCast = true;
                            summonAttack = true;
                            AttackName = "MeteorStrike";
                            AktSummonItem = Meteor;
                            AttackSpawn = new Vector3(Random.Range(enemieTarget.transform.position.x - 5, enemieTarget.transform.position.x + 5), (enemieTarget.transform.position.y + 20), Random.Range(enemieTarget.transform.position.z - 5, enemieTarget.transform.position.z + 5));
                            break;
                        case 4:
                            // Heal
                            enemieCast = 0;
                            enemieMaxCast = 7;
                            inCast = true;
                            healAttack = true;
                            AttackName = "Cleansing";
                            heal = 10;
                            break;
                        case 5:
                            //HellFlame
                            enemieCast = 0;
                            enemieMaxCast = 5;
                            inCast = true;
                            summonAttack = true;
                            AttackName = "Hellflame";
                            AktSummonItem = Hellflame;
                            AttackSpawn = enemieTarget.transform.position;
                            aktAtk = 1;
                            break;
                    }
                }
            }
            else if (distance > followDistance)
            {
                walk = false;
                enemieTarget = null;
            }
        }
    }

    public void Hit()
    {
        if (enemieCast >= enemieMaxCast)
        {
            if (GetComponent<EnemieNameScript>().Class == "Spider")
            {
                EnemieAudioSource.clip = SpiderSound;
            }
            else if (GetComponent<EnemieNameScript>().Class == "Goblin")
            {
                EnemieAudioSource.clip = GoblinSound;
            }
            else if (GetComponent<EnemieNameScript>().Class == "Skeleton")
            {
                EnemieAudioSource.clip = SkeletonSound;
            }
            else if (GetComponent<EnemieNameScript>().Class == "Wizzard")
            {
                EnemieAudioSource.clip = WizzardSound;
            }
            else if (GetComponent<EnemieNameScript>().Class == "God")
            {
                EnemieAudioSource.clip = TheobrasSound;
            }
            enemieAnimator.SetTrigger("hit");
            autoHit = false;
            PlayerStaticValuesScript.Life -= damage * attack;
            EnemieAudioSource.Play();
        }
    }
    public void MadnessDelete()
    {
        madneess = false;
        castSpeed = 1;
    }

    public void CastAttack()
    {
        if (enemieCast >= enemieMaxCast)
        {
            if (GetComponent<EnemieNameScript>().Class == "Spider")
            {
                EnemieAudioSource.clip = SpiderSound;
            }
            else if (GetComponent<EnemieNameScript>().Class == "Goblin")
            {
                EnemieAudioSource.clip = GoblinSound;
            }
            else if (GetComponent<EnemieNameScript>().Class == "Skeleton")
            {
                EnemieAudioSource.clip = SkeletonSound;
            }
            else if (GetComponent<EnemieNameScript>().Class == "Wizzard")
            {
                EnemieAudioSource.clip = WizzardSound;
            }
            else if (GetComponent<EnemieNameScript>().Class == "God")
            {
                EnemieAudioSource.clip = HeavyTheobrasSound;
            }
            inCast = false;
            enemieAnimator.SetTrigger("Cast");
            CastParticle.SetActive(false);
            if (hitAttack)
            {
                PlayerStaticValuesScript.Life -= damage;
                hitAttack = false;
            }
            else if (summonAttack)
            {
                GenerateMeteor();
                summonAttack = false;
            }
            else if (healAttack)
            {
                life += heal;
                healAttack = false;
            }
            aktAtk = 1;
            EnemieAudioSource.Play();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    // Geerierende Angriffe
    public void GenerateMeteor()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject.Instantiate(AktSummonItem, AttackSpawn, Quaternion.identity);
        }
    }
}
