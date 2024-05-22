using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healler : MonoBehaviour
{
    [SerializeField] private GameObject LittleShilds;
    [SerializeField] private GameObject Place1;
    [SerializeField] private GameObject Place2;
    [SerializeField] private GameObject Place3;
    [SerializeField] private GameObject Place4;
    float timeHeal;
    void Start()
    {
        GameObject FirstShield =  Instantiate(LittleShilds,Place1.transform);
        GameObject SecondShield = Instantiate(LittleShilds,Place2.transform);
        GameObject ThirdShield = Instantiate(LittleShilds,Place3.transform);
        GameObject FourthShield = Instantiate(LittleShilds,Place4.transform);
        array = new GameObject[] { FirstShield, SecondShield, ThirdShield, FourthShield };
        timeHeal = Time.time;
    }
    GameObject[] array;
    void Update()
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].GetComponent<EnemyDamage>().InteractWhithBar > 0)
            {
                gameObject.GetComponent<Button>().interactable = false;
                return;
            }
            else
            {
                gameObject.GetComponent<Button>().interactable = true;
            }
        }
        if (Time.time-timeHeal > 2)
        {
            IsHealing();
            timeHeal =Time.time;
        }
    }
    public void IsHealing()
    {
        GameObject[] objectsWithTag1 = GameObject.FindGameObjectsWithTag("GroundEnemy");
        foreach (GameObject obj in objectsWithTag1)
        {
            obj.GetComponent<EnemyDamage>().InteractWhithBar += 0.5f;
        }
        GameObject[] objectsWithTag2 = GameObject.FindGameObjectsWithTag("Flying");
        foreach (GameObject obj in objectsWithTag2)
        {
            obj.GetComponent<EnemyDamage>().InteractWhithBar += 0.5f;
        }
    }


}
