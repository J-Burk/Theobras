using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenBossFightScript : MonoBehaviour
{
    public GameObject Player;
    public float distance;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {        
        distance = Vector3.Distance(Player.transform.position, transform.position);

        if (distance < 10)
        {
            SceneManager.LoadScene(2);
        }
    }
}
