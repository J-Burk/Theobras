using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerScript : MonoBehaviour
{    
    public string Name;
    public string PlayerClass;

    public Transform Choosen;
    public Transform Target;
    public Camera Camera;
    public GameObject HUD;
    public GameObject AktSummonItem;
    public GameObject Inventar;
    public Vector3 SummonPosition;

    public AudioSource SkillAudioSource;
    public AudioClip SwordAttack;
    public AudioClip HeavyHit;
    public AudioClip Magicattack;
    public AudioClip CastAttack;
    public AudioClip MaxDistance;

    public bool walk;
    public bool backwalk;

    public bool stun;
    public bool inCast;
    public bool healAttack;
    public bool summonAttack;
    public bool castHitAttack;
    public bool autoHitReady;
    public bool die;
    public bool lastCast;
    
    public bool scrollCastBoost;
    public bool skillCastBoost;
    public bool scrollWalkBoost;
    public bool skillWalkBoost;

    public float walkSpeed;
    public float flightSpeed;
    public float horizontalInput;
    public float verticalInput;
    public float rotationValue;
    public float castSpeed;
    public float cast;
    public float maxCast;
    public float damage;
    public float plusDamage;
    public float heal;
    public float distance;
    public float maxDistance;
    public float finishDistance;

    public float scrollCastBoostTimer;
    public float skillCastBoostTimer;
    public float scrollWalkBoostTimer;
    public float skillWalkBoostTimer;

    public Animator CharacterAnimator;

    private RaycastHit choose;
    private Ray chooseRay;

    void Start()
    {
        die = false;
        cast = 0;
        castSpeed = 1;
        heal = 0;
        walkSpeed = 2.0f;
        damage = 100 * PlayerStaticValuesScript.Level;
        plusDamage = 0;

        Name = PlayerStaticValuesScript.PlayerName;
        CharacterAnimator = gameObject.GetComponent<Animator>();
        SkillAudioSource = GetComponent<AudioSource>();
       
        stun = false;
        inCast = false;
        healAttack = false;
        summonAttack = false;
        castHitAttack = false;
        autoHitReady = true;
    }

    void Update()
    {
        PlayerClass = PlayerStaticValuesScript.PlayerClass;
        CharacterAnimator.SetBool("walk", walk);
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        rotationValue += horizontalInput * 3;
        transform.position += transform.forward * verticalInput * walkSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, rotationValue, 0), Time.deltaTime * 100);

        if (Target != null)
        {
            distance = Vector3.Distance(Target.position, transform.position);
        }
        if (distance > 50)
        {
            Target = null;
        }

        if (verticalInput > 0)
        {
            walk = true;
            backwalk = false;
        }
        else if (verticalInput < 0)
        {
            walk = false;
            backwalk = true;
        }
        else if (verticalInput == 0)
        {
            walk = false;
            backwalk = false;
        }


        if (Input.GetMouseButtonDown(0))
        {
            chooseRay = Camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(chooseRay, out choose))
            {
                Choosen = choose.transform;
                if (Choosen.gameObject.tag == "Enemie")
                {
                    Target = choose.transform;
                }
            }
        }

        // Skillaktivierungen und Schnelltasten
        if (PlayerClass == "Soldier")
        {
            if (Input.GetKeyDown("1"))
            {
                maxDistance = 5;
                if (distance <= maxDistance)
                {
                    AutoHit();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("2"))
            {
                maxDistance = 5;
                if (distance <= maxDistance)
                {
                    GetComponent<SoldierSkillScript>().HeavyHit();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("3"))
            {
                GetComponent<SoldierSkillScript>().SmalShield();
            }
            if (Input.GetKeyDown("4"))
            {
                GetComponent<SoldierSkillScript>().HardShield();
            }
            if (Input.GetKeyDown("5"))
            {
                maxDistance = 5;
                if (distance <= maxDistance)
                {
                    GetComponent<SoldierSkillScript>().CrossHit();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("6") && PlayerStaticValuesScript.Level >=5)
            {
                maxDistance = 5;
                if (distance <= maxDistance)
                {
                    GetComponent<SoldierSkillScript>().SwordPower();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("7") && PlayerStaticValuesScript.Level >= 10)
            {
                maxDistance = 5;
                if (distance <= maxDistance)
                {
                    GetComponent<SoldierSkillScript>().SwordHammer();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("8") && PlayerStaticValuesScript.Level >= 15)
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    GetComponent<SoldierSkillScript>().Madness();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("9") && PlayerStaticValuesScript.Level >= 20)
            {
                GetComponent<SoldierSkillScript>().MovePower();
            }
            if (Input.GetKeyDown("0") && PlayerStaticValuesScript.Level >= 25)
            {
                maxDistance = 5;
                if (distance <= maxDistance)
                {
                    GetComponent<SoldierSkillScript>().SoldiersWill();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
        }
        else if (PlayerClass == "Priest")
        {
            if (Input.GetKeyDown("1"))
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    AutoHit();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("2"))
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    GetComponent<PriestSkillScript>().Smite();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("3"))
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    GetComponent<PriestSkillScript>().PowerSmash();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("4"))
            {
                GetComponent<PriestSkillScript>().SmalBlessing();
            }
            if (Input.GetKeyDown("5"))
            {
                GetComponent<PriestSkillScript>().Blessing();
            }
            if (Input.GetKeyDown("6") && PlayerStaticValuesScript.Level >= 5)
            {
                GetComponent<PriestSkillScript>().HealingLight();
            }
            if (Input.GetKeyDown("7") && PlayerStaticValuesScript.Level >= 10)
            {
                GetComponent<PriestSkillScript>().HealingWind();
            }
            if (Input.GetKeyDown("8") && PlayerStaticValuesScript.Level >= 15)
            {
                GetComponent<PriestSkillScript>().CastPlus();
            }
            if (Input.GetKeyDown("9") && PlayerStaticValuesScript.Level >= 20)
            {
                GetComponent<PriestSkillScript>().ManaBlessing();
            }
            if (Input.GetKeyDown("0") && PlayerStaticValuesScript.Level >= 25)
            {
                GetComponent<PriestSkillScript>().Madness();
            }
        }
        else if (PlayerClass == "Magican")
        {
            if (Input.GetKeyDown("1"))
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    AutoHit();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }

            }
            if (Input.GetKeyDown("2"))
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    GetComponent<MagicanSKillScript>().Firebolt();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("3"))
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    GetComponent<MagicanSKillScript>().Waterbolt();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("4"))
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    GetComponent<MagicanSKillScript>().Thunderbolt();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("5"))
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    GetComponent<MagicanSKillScript>().Iceshock();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("6") && PlayerStaticValuesScript.Level >= 5)
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    GetComponent<MagicanSKillScript>().Fireexplosion();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
            if (Input.GetKeyDown("7") && PlayerStaticValuesScript.Level >= 10)
            {
                GetComponent<MagicanSKillScript>().WindFeets();
            }
            if (Input.GetKeyDown("8") && PlayerStaticValuesScript.Level >= 15)
            {
                GetComponent<MagicanSKillScript>().CastPower();
            }
            if (Input.GetKeyDown("9") && PlayerStaticValuesScript.Level >= 20)
            {
                GetComponent<MagicanSKillScript>().MagicAbsorb();
            }
            if (Input.GetKeyDown("0") && PlayerStaticValuesScript.Level >= 25)
            {
                maxDistance = 15;
                if (distance <= maxDistance)
                {
                    GetComponent<MagicanSKillScript>().Iceicle();
                }
                else
                {
                    SkillAudioSource.clip = MaxDistance;
                    SkillAudioSource.Play();
                }
            }
        }

        // Kampf und Aktionsaktivierung
        if (inCast)
        {
            cast += 1 * Time.deltaTime * castSpeed;
            PlayerCastAttack();
        }
        // Boostregelung ( Cast und Laufboost und Dauer)
        if (scrollCastBoost && skillCastBoost)
        {
            castSpeed = 1.6f;
        }
        else if ((!scrollCastBoost && skillCastBoost) || (scrollCastBoost && !skillCastBoost))
        {
            castSpeed = 1.3f;
        }
        else if (!scrollCastBoost && !skillCastBoost)
        {
            castSpeed = 1;
        }

        if (scrollWalkBoost && skillWalkBoost)
        {
            walkSpeed = 6;
        }
        else if ((!scrollWalkBoost && skillWalkBoost) || (scrollWalkBoost && !skillWalkBoost))
        {
            walkSpeed = 4;
        }
        else if (!scrollWalkBoost && !skillWalkBoost)
        {
            walkSpeed = 2;
        }

        if (skillWalkBoostTimer <= 0)
        {
            skillWalkBoost = false;
        }
        else
        {
            skillWalkBoostTimer -= 1 * Time.deltaTime;
        }

        if (scrollWalkBoostTimer <= 0)
        {
            scrollWalkBoost = false;
        }
        else
        {
            scrollWalkBoostTimer -= 1 * Time.deltaTime;
        }

        if (skillCastBoostTimer <= 0)
        {
            skillCastBoost = false;
        }
        else
        {
            skillCastBoostTimer -= 1 * Time.deltaTime;
        }

        if (scrollCastBoostTimer <= 0)
        {
            scrollWalkBoost = false;
        }
        else
        {
            scrollCastBoostTimer -= 1 * Time.deltaTime;
        }

        if (PlayerStaticValuesScript.Life <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    // Castabläufe
    public void AutoHit()
    {
        if (autoHitReady && !inCast && !Target.GetComponent<EnemieAlphaScript>().die)
        {
            if (distance <= 25)
            {
                SkillAudioSource.clip = SwordAttack;
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Target.position - transform.position), rotationValue * 1000 * Time.deltaTime);
                Target.GetComponent<EnemieAlphaScript>().life -= damage + (plusDamage * PlayerStaticValuesScript.Level);
                CharacterAnimator.SetTrigger("Attack");
                autoHitReady = false;
                SkillAudioSource.Play();
                Invoke("AttackReady", 2);
            }
        }
    }
    public void PlayerCastAttack()
    {
        if (cast >= maxCast)
        {
            inCast = false;
            CharacterAnimator.SetTrigger("Attack");
            if (castHitAttack)
            {
                SkillAudioSource.clip = HeavyHit;
                Target.GetComponent<EnemieAlphaScript>().life -= damage;
                castHitAttack = false;
            }
            else if (summonAttack)
            {
                SkillAudioSource.clip = CastAttack;
                SummonGeneratetItem();
                summonAttack = false;
            }
            else if (healAttack)
            {
                SkillAudioSource.clip = CastAttack;
                if (PlayerStaticValuesScript.Life + heal <= PlayerStaticValuesScript.MaxLife)
                {
                    PlayerStaticValuesScript.Life += heal;
                }
                else
                {
                    PlayerStaticValuesScript.Life = PlayerStaticValuesScript.MaxLife;
                }
                healAttack = false;
            }
            SkillAudioSource.Play();
        }
    }
    public void SummonGeneratetItem()
    {
        GameObject.Instantiate(AktSummonItem, SummonPosition, Quaternion.identity);
    }
    public void AttackReady()
    {
        autoHitReady = true;
    }
}