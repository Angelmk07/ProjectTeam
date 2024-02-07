using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AddHealbar : MonoBehaviour
{
    public static bool IsHealHave = false;
    [SerializeField] private Image HealBar_2Collor;
    public void ClickOnHeal()
    {
        IsHealHave = true;
        HealBar_2Collor.color = Color.white;
    }
}
