
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
    [SerializeField] private Button Isactiv;
    [SerializeField] private TextMeshProUGUI NewExp;
    [SerializeField] private GameObject NewExpHiBy;
    [SerializeField] private Slider EnemyBar_S;

    //public  Animation  anim ;
    

    

    void Update()
    {
        bool IsRelead = DeadFirstEpizode.IsDead;
        if (IsRelead)
        {
            ScinChnge.color = Color.red;
            EnemyBar.fillAmount = 1f;
            EnemyBar_S.value = 1f;
            DeadFirstEpizode.IsDead = false;

        }
        if (EnemyBar_S.value == 0f)
        {




            //anim.Play("Dead");
            StartCoroutine("Money");
            StartCoroutine("Dead");

            _clicksBankView.text = $"Exp {_clicksBank.Clicks++} ";
            ScinChnge.color = Random.ColorHSV();

            EnemyBar_S.value = 1f;
            EnemyBar.fillAmount = 1f;
            //EnemyBar.sprite = Brain;
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
       transform.DOShakeRotation(1.5f, 10f, 5, 60, true, ShakeRandomnessMode.Full);

        StartCoroutine("reternghost");



        EnemyBar.fillAmount -= Damage.Pover;
        EnemyBar_S.value -= Damage.Pover;




    }
    IEnumerator reternghost()
    {
        yield return new WaitForSeconds(3f);

        transform.DORotateQuaternion(Quaternion.identity, 2f);
    }
    IEnumerator Dead()
    {
        Isactiv.interactable = false;
        transform.DOShakeRotation(1.5f, 50f, 9, 90, true, ShakeRandomnessMode.Full);
        yield return new WaitForSeconds(1.5f);
        transform.DORotateQuaternion(Quaternion.identity, 1f);
        yield return new WaitForSeconds(1f);
        Isactiv.interactable = true;

    }
    IEnumerator Money()
    {
        
        _clicksBank.Clicks += 500;
        NewExpHiBy.SetActive(true);
        yield return new WaitForSeconds(2f);
        NewExp.text = $"+500";
        NewExpHiBy.SetActive(false);
    }

}
