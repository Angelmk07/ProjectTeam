
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Random = UnityEngine.Random;
using DG.Tweening;



public class EnemyDamage : MonoBehaviour
{
    [SerializeField] public AudioSource SoundPlay;
    [SerializeField] private TextMeshProUGUI _clicksBankView;
    [SerializeField] private Image EnemyBar;
    [SerializeField] private BrainHeats Damage;
    [SerializeField] private ClicksBank _clicksBank;
    [SerializeField] public Image ScinChnge;
    [SerializeField] public Sprite Brain;
    //public  Animation  anim ;
    

    

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

    //private void Awake()
    //{
     //   anim = GetComponent<Animation>();
    //}
    IEnumerator DelayedFunction(float delay)
    {
        yield return new WaitForSeconds(delay);
       
    }

    public void EnemyHeatDamage()
    { 
       SoundPlay.Play();

        


        EnemyBar.fillAmount -= Damage.Pover;

        
        if (EnemyBar.fillAmount == 0)
        {

            Color newRndColor = Random.ColorHSV();
           
            
            //anim.Play("Dead");
            _clicksBank.Clicks += 500;
            _clicksBankView.text = $"Exp {_clicksBank.Clicks++} ";
            ScinChnge.color = Random.ColorHSV();
            
            
            EnemyBar.fillAmount = 1f;
            //EnemyBar.sprite = Brain;
        }
        

    }
}
