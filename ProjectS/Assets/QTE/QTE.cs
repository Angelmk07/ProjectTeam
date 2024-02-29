using System;
using System.Collections;
using System.Collections.Generic;
using Unity.EditorCoroutines.Editor;
using UnityEngine;
using UnityEngine.UI;


public class QTE : MonoBehaviour
{
    [SerializeField] private GameObject shouQwe_1;
    [SerializeField] private GameObject shouQwe_2;
    [SerializeField] private GameObject shouQwe_3;

    [SerializeField] private Image TrueQTE_1;
    [SerializeField] private Image TrueQTE_2;
    [SerializeField] private Image TrueQTE_3;
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
            if (Input.GetKeyDown(KeyCode.S) && TrueQTE_1.color != Color.green)
                TrueQTE_1.color = Color.green;
            else if (Input.GetKeyDown(KeyCode.S) && TrueQTE_1.color == Color.green)
                TrueQTE_2.color = Color.green;
            if (Input.GetKey(KeyCode.D) && TrueQTE_2.color == Color.green)
            {
                TrueQTE_3.color = Color.green;
                StopCoroutine(coroutineQTE);
                QTE_Off();
                EnemyBar_S.value -= 0.2f;
                _Started = false;
                coroutineQTE = StartCoroutine(StartQTE());
                
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
        TrueQTE_1.color = color;
        TrueQTE_2.color = color;
        TrueQTE_3.color = color;
    }
    void changeVision(bool status)
    {
        shouQwe_1.SetActive(status);
        shouQwe_2.SetActive(status);
        shouQwe_3.SetActive(status);
    }

}
