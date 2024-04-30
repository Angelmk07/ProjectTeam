using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TwoKnifes : MonoBehaviour
{
    static int lvl = 0;
    static int chanse = 5;
    static public int PoverBust;
    int cost=200;
    public void OnClick()
    {
        if(cost<AttackMoneyBank.MoneyForTeam)
        {
            AttackMoneyBank.MoneyForTeam -= cost;
        }
        lvl += 1;
    }
    public static void DoubleAttack()
    {

        int rnd = Random.Range(0, 101);
        if(rnd <= chanse+4*lvl)
        {
            PoverBust = 2;
        }
        else
        {
            PoverBust = 1;
        }
    }

}
