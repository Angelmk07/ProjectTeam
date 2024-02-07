using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AddHealbar : MonoBehaviour
{
    [SerializeField] private ClicksBank _clicksBank;
    public static bool IsHealHave = false;
    [SerializeField] private Image HealBar_2Collor;
    private int cost = 4000;
    private bool Isbuy = true;
    public void ClickOnHeal()
    {
        if (((_clicksBank.Clicks - cost)> 0)&&Isbuy)
        {
            _clicksBank.Clicks -= cost;
            IsHealHave = true;
            HealBar_2Collor.color = Color.white;
            Isbuy = false;
        }

    }
}
