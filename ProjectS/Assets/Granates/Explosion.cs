using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    [SerializeField] private ClicksBank Exp;

    EnemyDamage enemyDamage = new EnemyDamage();

    private bool cancelebuy = true;
    private int cost = 500;
    private float explor_pover = 10f;



    public void Start()
    {
        if ((Exp.Clicks - cost) > 0&& cancelebuy)
        {

            
            Exp.Clicks -= cost;
            cancelebuy = false;
        }


    }
    public void ExploreGranade(GameObject gameObject)
    {
        gameObject.GetComponent<EnemyDamage>().EnemyHeatBygranade();
        gameObject.GetComponent<EnemyDamage>().InteractWhithBar -= gameObject.GetComponent<EnemyDamage>().InteractWhithBar / 2;

    }

}