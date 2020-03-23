using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemieAlphaScript : MonoBehaviour
{
    GameObject Player;
    public Transform enemieTarget;

    Animator enemieAnimator;

    public string Name;

    public float maxLife;
    public float life;
    public float distance;
    public float moveSpeed;
    public float rotationSpeed;
    public bool die;
    public bool walk;
    public bool hit;
    public bool inMove;

    void Start()
    {
        Name = GetComponent<EnemieNameScript>().Name;
        if (Name == "Spider")
        {
            maxLife = 200;
            life = 200;
        }
        else
        {
            maxLife = 100;
            life = 100;
        }
        moveSpeed = 2;
        rotationSpeed = 5;

        walk = false;
        die = false;
        hit = false;
        inMove = false;

        Player = GameObject.FindGameObjectWithTag("Player");
        enemieTarget = GameObject.FindGameObjectWithTag("Player").transform;
        enemieAnimator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (enemieAnimator != null)
        {
            enemieAnimator.SetBool("die", die);
            enemieAnimator.SetBool("walk", walk);
            enemieAnimator.SetBool("hit", hit);
        }

        distance = Vector3.Distance(enemieTarget.position, transform.position);
        Debug.Log("Abstand beträgt: " + distance);
        
        RangeChecker();
        if (life <= 0)
        {
            Invoke("Die", 5);
            die = true;
        }
    }

    public void RangeChecker()
    {
        if( distance <= 10 && distance > 3 && !inMove && !die)
        {            
            walk = true;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(enemieTarget.position - transform.position), rotationSpeed * Time.deltaTime);
            transform.position += transform.forward *Time.deltaTime * moveSpeed ;
        }
        else if (distance <= 3 && !die)
        {
            Hit();
            walk = false;
        }

        //if (Vector3.Distance(Player.transform.position, transform.position) <= 5 && !inMove && !die)
        //{
        //    Hit();
        //}
        //else
        //{
        //    hit = false;
        //}
    }

    public void Hit()
    {
        hit = true;
        if (!inMove)
        {
            PlayerStaticValuesScript.Life -= 10;
            inMove = true;
            Invoke("SetBack", 3);
        }

    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void SetBack()
    {
        inMove = false;
    }
}
