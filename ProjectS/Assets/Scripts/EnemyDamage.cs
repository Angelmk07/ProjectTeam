
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] public AudioSource SoundPlay;
    [SerializeField] private TextMeshProUGUI _clicksBankView;
    [SerializeField] private Image EnemyBar;
    [SerializeField] private BrainHeats Damage;
    [SerializeField] private ClicksBank _clicksBank;
    [SerializeField] private Image ScinChnge;

    

    void Update()
    {
        bool IsRelead = DeadFirstEpizode.IsDead;
        if (IsRelead)
        {
            ScinChnge.color = Color.red;
            EnemyBar.fillAmount = 1f;

            DeadFirstEpizode.IsDead = false;
        }
    }

    public void EnemyHeatDamage()
    { 
       SoundPlay.Play();

        


        EnemyBar.fillAmount -= Damage.Pover;

        if (EnemyBar.fillAmount == 0)
        {
            _clicksBank.Clicks += 2000;
            _clicksBankView.text = $"Exp {_clicksBank.Clicks++} ";
            ScinChnge.color = Color.blue;
            EnemyBar.fillAmount = 1f;
        }
        

    }
}
