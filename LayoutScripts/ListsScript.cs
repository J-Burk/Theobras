using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsScript : MonoBehaviour
{
    public GameObject SkillList;
    public GameObject Options;

    public bool skillListActiv;
    public bool optionsActiv;

    void Start()
    {
        Options.SetActive(false);
        SkillList.SetActive(false);
        skillListActiv = false;
        optionsActiv = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (!optionsActiv)
            {
                Options.SetActive(true);
                optionsActiv = true;
            }
            else
            {
                Options.SetActive(false);
                optionsActiv = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (!skillListActiv)
            {
                SkillList.SetActive(true);
                skillListActiv = true;
            }
            else
            {
                SkillList.SetActive(false);
                skillListActiv = false;
            }
        }
    }
}
