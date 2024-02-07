using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private Image EnemyBar;
    [SerializeField] private BrainHeats Damage;

    public void EnemyHeatDamage()
    {
        EnemyBar.fillAmount -= Damage.Pover;
    }
}
