using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PasivHeal : MonoBehaviour
{
    [SerializeField] private Image Healbar;
    [SerializeField] private Image HealBar_2;
    [SerializeField] private ClicksBank Exp;
    [SerializeField] private Image isPaviv;
    private bool Isbuy = true;
    public static bool IsbuyDo = false;
    private int cost = 5000;

    public void Start()
    {
        if ((Exp.Clicks - cost )> 0 && Isbuy)
        {
            Isbuy = false;

            Exp.Clicks -= cost;
            isPaviv.color = Color.white;
            IsbuyDo = true;
        }
        
    }

   


}