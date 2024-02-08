using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Autoheal : MonoBehaviour
{
    [SerializeField] private Image Healbar;
    [SerializeField] private Image HealBar_2;
    private bool isDo = PasivHeal.IsbuyDo;
    public static bool isDoStop = true ;
    public void Update()
    {
        isDo = PasivHeal.IsbuyDo;
        
        if (isDo&& isDoStop)
        {
            StartCoroutine(Delay());
            isDoStop = false;
        }
        

    }
    IEnumerator Delay()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            bool _IsHaveHeal = AddHealbar.IsHealHave;
            if (_IsHaveHeal)
            {
                if (HealBar_2.fillAmount <= 0)
                {
                    Healbar.fillAmount += 0.15f;
                }
                else
                {
                    HealBar_2.fillAmount += 0.15f;
                }
            }
            else
            {
                Healbar.fillAmount += 0.15f;
            }
        }
    }
}
