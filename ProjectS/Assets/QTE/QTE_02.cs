using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class QTE_02 : MonoBehaviour
{
    [SerializeField] Image QTEBeackGround;
    [SerializeField] Image QTEBeackGroundFilled;
    [SerializeField] GameObject QTE1;
    [SerializeField] GameObject QTE2;
    [SerializeField] GameObject QTE3;
    [SerializeField] GameObject QTE4;
    int i = 0;
    bool isPass;
    float t;
    private KeyCheck _KeyCheck = new KeyCheck { };
    private static KeyCode[] keyCodevalidkeys1 = new KeyCode[] { KeyCode.S, KeyCode.S, KeyCode.D };
    private static KeyCode[] keyCodevalidkeys2 = new KeyCode[] { KeyCode.S, KeyCode.S,KeyCode.W, KeyCode.D };
    private static KeyCode[] keyCodevalidkeys3 = new KeyCode[] { KeyCode.W, KeyCode.W, KeyCode.W,KeyCode.W,KeyCode.A,KeyCode.A,KeyCode.D };
    private static KeyCode[] keyCodevalidkeys4 = new KeyCode[] { KeyCode.S, KeyCode.W, KeyCode.S,KeyCode.W,KeyCode.A,KeyCode.W,KeyCode.W,KeyCode.W,KeyCode.A,KeyCode.A,KeyCode.D,KeyCode.D,KeyCode.D,KeyCode.W };
    private KeyCode[][] keyCodes = new KeyCode[][] { keyCodevalidkeys1, keyCodevalidkeys2 , keyCodevalidkeys3 , keyCodevalidkeys4 };
    bool isStarted = true;
    private void Update()
    {

        if (isStarted)
        {
            t = Time.time;
            isPass = false;
            isStarted = false;
            AddLvlQTE();
            
        }
        if (isStarted != true)
        {
            foreach (var key in keyCodes[i])
            {
                _KeyCheck.InputKey(key);
                break;
            }
            QTEBeackGroundFilled.fillAmount += Time.deltaTime * 1f / 15f;
        }

       
        if(Time.time - t >15f|| isPass)
        {
            ShowQTE(i);
            QTEBeackGroundFilled.fillAmount = 0;
        }
        if (Time.time - t > 60f )
        {
            isStarted = true;


        }

    }
  
    private void AddLvlQTE()
    {
        int rnd = Random.Range(0, 3);
        //switch (rnd)
        //{
        //    case 0:
        //        i = 0; break;
        //    case 1:
        //        i = 1; break;
        //    case 2:
        //        i = 2; break;
        //    case 3:
        //        i = 3; break;
        //    default:
        //        throw new ArgumentException();
        //}
        i = rnd;
        ShowQTE(i); 
        _KeyCheck.setOrder(keyCodes[i]);
        _KeyCheck.OnPass.AddListener(OnPass);
        _KeyCheck.OnMisstake.AddListener(OnMisstake);

    }
    private void OnMisstake()
    {
        OnMisstakeC();
    }
    private void OnPass()
    {
        OnPassC();

    }
    IEnumerator OnMisstakeC()
    {
        QTEBeackGround.color = Color.red;
        yield return new WaitForSeconds(4f);
        QTEBeackGround.color = Color.white;

    }
    IEnumerator OnPassC()
    {
        QTEBeackGround.color = Color.green;
        yield return new WaitForSeconds(4f);
        QTEBeackGround.color = Color.white;
    }
    private void ShowQTE(int i)
    {
        switch(i)
        {
            case 0:
                QTE1.SetActive(!QTE1.activeSelf);
                QTEBeackGround.gameObject.SetActive(!QTEBeackGround.gameObject.activeSelf);
                break;
            case 1:
                QTE2.SetActive(!QTE2.activeSelf);
                QTEBeackGround.gameObject.SetActive(!QTEBeackGround.gameObject.activeSelf);
                break;
            case 2:
                QTE3.SetActive(!QTE3.activeSelf);
                QTEBeackGround.gameObject.SetActive(!QTEBeackGround.gameObject.activeSelf);
                break;
            case 3:
                QTE4.SetActive(!QTE4.activeSelf);
                QTEBeackGround.gameObject.SetActive(!QTEBeackGround.gameObject.activeSelf);
                break;
            default:
                break;
        }
    }

}
