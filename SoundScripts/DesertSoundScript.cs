using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertSoundScript : MonoBehaviour
{
    private AudioSource DesertAudio;
    void Start()
    {
        DesertAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            DesertAudio.Play();
        }
    }
    public void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            DesertAudio.Stop();
        }
    }

}
