using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltScript : MonoBehaviour
{
    GameObject Player;
    public float distance;
    public Transform Target;
    public float moveSpeed = 5;
    public float rotationSpeed = 5;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Target = Player.GetComponent<PlayerControllerScript>().Target;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Target.position - transform.position), rotationSpeed * Time.deltaTime);
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
        distance = Vector3.Distance(Player.GetComponent<PlayerControllerScript>().Target.transform.position, transform.position);
        if (distance < 2)
        {
            Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().life -= 50 * PlayerStaticValuesScript.Level;
            Destroy(gameObject);
        }

    }
}
