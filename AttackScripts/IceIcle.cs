using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceIcle : MonoBehaviour
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
        distance = Vector3.Distance(Player.GetComponent<PlayerControllerScript>().Target.transform.position, transform.position);
        if (distance < 2)
        {
            Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().life -= 100 * PlayerStaticValuesScript.Level;
            Destroy(gameObject);
        }

    }
}
