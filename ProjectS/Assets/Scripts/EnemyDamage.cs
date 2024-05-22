
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
    [SerializeField] private TextMeshProUGUI _clicksBankView ;
    [SerializeField] private ClicksBank _clicksBank ;
    [SerializeField] public Image ScinChnge;
    [SerializeField] public Sprite Brain;
    [SerializeField] private Button Isactiv;
    [SerializeField] private GameObject NewExpHiBy ;
    [SerializeField] private Slider EnemyBar_S;

    private void Start()
    {
        NewExpHiBy = GameObject.Find("Scoreadd");
        _clicksBank = GameObject.Find("BankSystem").GetComponent<ClicksBank>();
        _clicksBankView = GameObject.Find("Bank").GetComponent<TextMeshProUGUI>();
        SoundPlay = GameObject.Find("SoundSystem").GetComponent<AudioSource>();
    }
    public float InteractWhithBar {  get => EnemyBar_S.value;  set=> EnemyBar_S.value = value; }





    void Update()
    {
        bool IsRelead = DeadFirstEpizode.IsDead;
        if (IsRelead)
        {
            ScinChnge.color = Color.red;
            EnemyBar_S.value = 1f;
            DeadFirstEpizode.IsDead = false;

        }
        if (EnemyBar_S.value <= 0.01f)
        {
            StartCoroutine("Money");
            StartCoroutine("Dead");

            _clicksBankView.text = $"Exp {_clicksBank.Clicks++} ";
            ScinChnge.color = Random.ColorHSV();

            EnemyBar_S.value = 1f;
        }

    }


    IEnumerator DelayedFunction(float delay)
    {
        yield return new WaitForSeconds(delay);
       
    }

    public void EnemyHeatDamage()
    {
        TwoKnifes.DoubleAttack();
        SoundPlay.Play();
        transform.DOShakeRotation(1.5f, 10f, 5, 60, true, ShakeRandomnessMode.Full);

        StartCoroutine("reternghost");
        EnemyBar_S.value -= BrainHeats.Pover*TwoKnifes.PoverBust;
    }
    public void EnemyHeatBygranade()
    {
        TwoKnifes.DoubleAttack();
        SoundPlay.Play();
        transform.DOShakeRotation(1.5f, 10f, 5, 60, true, ShakeRandomnessMode.Full);

        StartCoroutine("reternghost");
    }
    IEnumerator reternghost()
    {
        yield return new WaitForSeconds(3f);

        transform.DORotateQuaternion(Quaternion.identity, 2f);
    }
    IEnumerator Dead()
    {
        Isactiv.interactable = false;
        transform.DOShakeRotation(1.5f, 50f, 9, 90, true, ShakeRandomnessMode.Harmonic);
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
        NewExpHiBy.GetComponent<TextMeshProUGUI>().text = $"+500";
        NewExpHiBy.SetActive(false);
    }


}
