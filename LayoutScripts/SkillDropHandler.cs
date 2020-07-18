using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SkillDropHandler : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        RectTransform skillPanel = transform as RectTransform;
        if (!RectTransformUtility.RectangleContainsScreenPoint(skillPanel, Input.mousePosition))
        {
            Debug.Log("Drop Skill");
        }
    }

}
