using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndScript : MonoBehaviour
{
    public float timer;
    void Start()
    {
        timer = 4;
    }

    void Update()
    {
        if (GetComponent<EnemieAlphaScript>().die == true)
        {
            timer -= 1 * Time.deltaTime;
        }
        if (timer <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
