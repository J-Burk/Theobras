using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerValuesScript : MonoBehaviour
{
    public int Level;
    public float maxLife;
    public float life;
    public float maxMana;
    public float mana;
    void Start()
    {
        maxLife = 100;
        maxMana = 100;
    }

    // Update is called once per frame
    void Update()
    {
        life = PlayerStaticValuesScript.Life;
        mana = PlayerStaticValuesScript.Mana;
    }
}
