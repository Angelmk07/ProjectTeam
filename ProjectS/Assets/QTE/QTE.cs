using System;
using System.Collections;
using System.Collections.Generic;
using Unity.EditorCoroutines.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;


public class QTE : MonoBehaviour
{
    [SerializeField] private GameObject showQwe_low;
    [SerializeField] private GameObject showQwe_medium;
    [SerializeField] private GameObject showQwe_hard;
    [SerializeField] private GameObject showQwe_Unreal;
    

    [SerializeField] private Image TrueQTE_1_FirstLvl;
    [SerializeField] private Image TrueQTE_2_FirstLvl;
    [SerializeField] private Image TrueQTE_3_FirstLvl;

    [SerializeField] private Image TrueQTE_1_SecondLvl;
    [SerializeField] private Image TrueQTE_2_SecondLvl;
    [SerializeField] private Image TrueQTE_3_SecondLvl; 
    [SerializeField] private Image TrueQTE_4_SecondLvl;

 

    [SerializeField] private Image TrueQTE_1_ThirdLvl;
    [SerializeField] private Image TrueQTE_2_ThirdLvl;
    [SerializeField] private Image TrueQTE_3_ThirdLvl;
    [SerializeField] private Image TrueQTE_4_ThirdLvl;
    [SerializeField] private Image TrueQTE_5_ThirdLvl;
    [SerializeField] private Image TrueQTE_6_ThirdLvl;
    [SerializeField] private Image TrueQTE_7_ThirdLvl;

    [SerializeField] private Image TrueQTE_1_UnrealLvl;
    [SerializeField] private Image TrueQTE_2_UnrealLvl;
    [SerializeField] private Image TrueQTE_3_UnrealLvl;
    [SerializeField] private Image TrueQTE_4_UnrealLvl;
    [SerializeField] private Image TrueQTE_5_UnrealLvl;
    [SerializeField] private Image TrueQTE_6_UnrealLvl;
    [SerializeField] private Image TrueQTE_7_UnrealLvl;
    [SerializeField] private Image TrueQTE_8_UnrealLvl;
    [SerializeField] private Image TrueQTE_9_UnrealLvl;
    [SerializeField] private Image TrueQTE_10_UnrealLvl;
    [SerializeField] private Image TrueQTE_11_UnrealLvl;
    [SerializeField] private Image TrueQTE_12_UnrealLvl;
    [SerializeField] private Image TrueQTE_13_UnrealLvl;
    [SerializeField] private Image TrueQTE_14_UnrealLvl;



    [SerializeField] private Image healbarcharacter;
    [SerializeField] private Slider EnemyBar_S;

    private readonly int _time = 10;
    //private bool _timeOut = true;
    //private bool _Damage;
    //private bool _NoDamage;
    private bool _Started = false;
    private bool QTE_heat = false;
    private bool complit = false;
    private int _StartedTime = 0;
    private Coroutine coroutineQTE;
    public void Start()
    {

        coroutineQTE = StartCoroutine(StartQTE());
            
    }
    void Update()
    {
        if (_Started == true)
        {
            if(showQwe_low.activeSelf == true)
            {
                if (Input.GetKeyDown(KeyCode.S) && TrueQTE_1_FirstLvl.color != Color.green)
                    TrueQTE_1_FirstLvl.color = Color.green;
                else if (Input.GetKeyDown(KeyCode.S) && TrueQTE_1_FirstLvl.color == Color.green)
                    TrueQTE_2_FirstLvl.color = Color.green;
                if (Input.GetKey(KeyCode.D) && TrueQTE_2_FirstLvl.color == Color.green)
                {
                    TrueQTE_3_FirstLvl.color = Color.green;
                    StopCoroutine(coroutineQTE);
                    QTE_Off();
                    EnemyBar_S.value -= 0.2f;
                    _Started = false;
                    showQwe_low.SetActive(false);
                    coroutineQTE = StartCoroutine(StartQTE());

                }
            }
            if (showQwe_medium.activeSelf == true)
            {
                if (Input.GetKeyDown(KeyCode.S) && TrueQTE_1_SecondLvl.color != Color.green)
                    TrueQTE_1_SecondLvl.color = Color.green;
                else if (Input.GetKeyDown(KeyCode.S) && TrueQTE_1_SecondLvl.color == Color.green)
                    TrueQTE_2_SecondLvl.color = Color.green;
                if (Input.GetKey(KeyCode.W) && TrueQTE_2_SecondLvl.color == Color.green)
                    TrueQTE_3_SecondLvl.color = Color.green;
                if(Input.GetKey(KeyCode.D) && TrueQTE_3_SecondLvl.color == Color.green)
                {
                    TrueQTE_4_SecondLvl.color = Color.green;    
                    StopCoroutine(coroutineQTE);
                    QTE_Off();
                    EnemyBar_S.value -= 0.2f;
                    _Started = false;
                    showQwe_medium.SetActive(false);
                    coroutineQTE = StartCoroutine(StartQTE());
                }
            }
            if (showQwe_hard.activeSelf == true)
            {
                if (Input.GetKeyDown(KeyCode.W) && TrueQTE_1_ThirdLvl.color != Color.green)
                    TrueQTE_1_ThirdLvl.color = Color.green;
                else if (Input.GetKeyDown(KeyCode.W) && TrueQTE_1_ThirdLvl.color == Color.green&& TrueQTE_1_ThirdLvl.color != Color.green)
                    TrueQTE_2_ThirdLvl.color = Color.green;
                else if (Input.GetKey(KeyCode.W) && TrueQTE_2_ThirdLvl.color == Color.green && TrueQTE_3_ThirdLvl.color != Color.green)
                    TrueQTE_3_ThirdLvl.color = Color.green;
                if (Input.GetKey(KeyCode.W) && TrueQTE_3_ThirdLvl.color == Color.green)
                    TrueQTE_4_ThirdLvl.color = Color.green;
                if (Input.GetKeyDown(KeyCode.A) && TrueQTE_5_ThirdLvl.color != Color.green&& TrueQTE_4_ThirdLvl.color == Color.green)
                    TrueQTE_5_ThirdLvl.color = Color.green;
                else if (Input.GetKeyDown(KeyCode.A) && TrueQTE_5_ThirdLvl.color == Color.green)
                    TrueQTE_6_ThirdLvl.color = Color.green;
                if (Input.GetKeyDown(KeyCode.D) && TrueQTE_6_ThirdLvl.color == Color.green)
                {
                    TrueQTE_7_ThirdLvl.color = Color.green;
                    StopCoroutine(coroutineQTE);
                    QTE_Off();
                    EnemyBar_S.value -= 0.2f;
                    _Started = false;
                    showQwe_hard.SetActive(false);
                    coroutineQTE = StartCoroutine(StartQTE());
                }
            }
            if (showQwe_Unreal.activeSelf == true)
            {
                if (Input.GetKeyDown(KeyCode.S))
                    TrueQTE_1_UnrealLvl.color = Color.green;
                if (Input.GetKeyDown(KeyCode.W) && TrueQTE_1_UnrealLvl.color == Color.green )
                    TrueQTE_2_UnrealLvl.color = Color.green;
                if (Input.GetKey(KeyCode.S) && TrueQTE_2_UnrealLvl.color == Color.green)
                    TrueQTE_3_UnrealLvl.color = Color.green;
                if (Input.GetKey(KeyCode.W) && TrueQTE_3_UnrealLvl.color == Color.green)
                    TrueQTE_4_UnrealLvl.color = Color.green;
                if (Input.GetKeyDown(KeyCode.A) && TrueQTE_4_UnrealLvl.color == Color.green)
                    TrueQTE_5_UnrealLvl.color = Color.green;
                if (Input.GetKeyDown(KeyCode.W) && TrueQTE_5_UnrealLvl.color == Color.green&& TrueQTE_6_UnrealLvl.color != Color.green)
                    TrueQTE_6_UnrealLvl.color = Color.green;
                else if (Input.GetKeyDown(KeyCode.W) && TrueQTE_6_UnrealLvl.color == Color.green&& TrueQTE_7_UnrealLvl.color != Color.green)
                    TrueQTE_7_UnrealLvl.color = Color.green;
                else if (Input.GetKeyDown(KeyCode.W) && TrueQTE_7_UnrealLvl.color == Color.green && TrueQTE_8_UnrealLvl.color != Color.green)
                    TrueQTE_8_UnrealLvl.color = Color.green;

                if (Input.GetKeyDown(KeyCode.A) && TrueQTE_8_UnrealLvl.color == Color.green && TrueQTE_9_UnrealLvl.color != Color.green)
                    TrueQTE_9_UnrealLvl.color = Color.green;
                else if (Input.GetKey(KeyCode.A) && TrueQTE_9_UnrealLvl.color == Color.green )
                    TrueQTE_10_UnrealLvl.color = Color.green;

                if (Input.GetKey(KeyCode.D) && TrueQTE_10_UnrealLvl.color == Color.green&& TrueQTE_11_UnrealLvl.color != Color.green )
                    TrueQTE_11_UnrealLvl.color = Color.green;
                else if (Input.GetKeyDown(KeyCode.D) && TrueQTE_11_UnrealLvl.color != Color.green && TrueQTE_12_UnrealLvl.color != Color.green)
                    TrueQTE_12_UnrealLvl.color = Color.green;
                else if (Input.GetKeyDown(KeyCode.D) && TrueQTE_12_UnrealLvl.color == Color.green)
                    TrueQTE_13_UnrealLvl.color = Color.green;
                if (Input.GetKeyDown(KeyCode.W) && TrueQTE_13_UnrealLvl.color == Color.green)
                {
                    TrueQTE_14_UnrealLvl.color = Color.green;
                    StopCoroutine(coroutineQTE);
                    QTE_Off();
                    EnemyBar_S.value -= 0.2f;
                    _Started = false;
                    showQwe_Unreal.SetActive(false);
                    coroutineQTE = StartCoroutine(StartQTE());
                }


            }



        }
    }



    IEnumerator StartQTE()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            if (_Started == false)
            {

                //_StartedTime = (int)(Time.realtimeSinceStartup);
                _Started = true;

            }


            changeVision(true);



            //int timeElapsed = (int)(Time.realtimeSinceStartup) - _StartedTime;
            // if (_time - timeElapsed <= 0 || complit)
            //{
            yield return new WaitForSeconds(10f);
            healbarcharacter.fillAmount -= 0.2f;


            _Started = false;
            //    if (QTE_heat)
            //    {
            //        EnemyBar_S.value -= 0.2f;
            //        QTE_heat = false;
            //    }
            //    else
            //    {
            //        healbarcharacter.fillAmount -= 0.2f;
            //    }
            //    complit = false;

            QTE_Off();



            // }
        }

    }

    private void QTE_Off()
    {
        changecolor(Color.white);
        changeVision(false);
    }

    void changecolor(Color color)
    {
        TrueQTE_1_FirstLvl.color = color;
        TrueQTE_2_FirstLvl.color = color;
        TrueQTE_3_FirstLvl.color = color;
    }
    void changeVision(bool status)
    {
        Random random = new Random();
        int rand = random.Next(0,4);
        switch(rand)
        {
            case 0:
                showQwe_low.SetActive(status);
                break;
            case 1:
                showQwe_medium.SetActive(status);
                break;
            case 2:
                showQwe_hard.SetActive(status);
                break;
            case 3:
                showQwe_Unreal.SetActive(status);
                break;
            default:
                break;
        }
       

    }

}
