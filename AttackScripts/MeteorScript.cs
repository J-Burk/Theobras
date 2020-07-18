using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour
{
    GameObject Player;
    public float distance;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        transform.position += Vector3.down * 10 * Time.deltaTime;
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if (distance < 2)
        {
            PlayerStaticValuesScript.Life -= 90;
            Destroy(gameObject);
        }
    }

}
