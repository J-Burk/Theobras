using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellFlameScript : MonoBehaviour
{
    GameObject Player;
    public float distance;
    public float timer;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        timer = 5;
    }

    void Update()
    {
        timer -= 1 * Time.deltaTime;
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if (distance < 2)
        {
            PlayerStaticValuesScript.Life -= 10  * Time.deltaTime;
        }
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
