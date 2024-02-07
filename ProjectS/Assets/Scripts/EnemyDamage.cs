using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private Image EnemyBar;
    [SerializeField] private BrainHeats Damage;
    [SerializeField] private ClicksBank _clicksBank;
    public void EnemyHeatDamage()
    {
        EnemyBar.fillAmount -= Damage.Pover;
        if (EnemyBar.fillAmount == 0)
        {
            _clicksBank.Clicks += 2000;
        }
    }
}
