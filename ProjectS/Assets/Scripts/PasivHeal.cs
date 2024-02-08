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
    private int cost= 5000;

    public void Start()
    {
        if ((Exp.Clicks - cost )> 0 && Isbuy)
        {
            Isbuy = false;
            StartCoroutine(Delay());
            Exp.Clicks -= cost;
            isPaviv.color = Color.white;

        }
        
    }

   

    IEnumerator Delay()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            bool _IsHaveHeal = AddHealbar.IsHealHave;
            if (_IsHaveHeal)
            {
                if (HealBar_2.fillAmount <= 0)
                {
                    Healbar.fillAmount += 0.2f;
                }
                else
                {
                    HealBar_2.fillAmount += 0.2f;
                }
            }
            else
            {
                Healbar.fillAmount += 0.2f;
            }
        }
    }
}