using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    GameObject Player;
    public float distance;
    public Transform Target;
    public float timer = 5;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        timer -= 1 * Time.deltaTime;
        Target = Player.GetComponent<PlayerControllerScript>().Target;
        transform.position = Target.transform.position;
        if (distance < 2)
        {
            Player.GetComponent<PlayerControllerScript>().Target.GetComponent<EnemieAlphaScript>().life--; 
            
        }
        if (timer <= 0)
        {
            DestroyYourself();
        }
    }
    public void DestroyYourself()
    {
        Destroy(gameObject);
    }
}
