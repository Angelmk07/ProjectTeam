using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TwoKnifes : MonoBehaviour
{
    internal static int lvl = 0;
    internal static int chanse = 5;
    static public int PoverBust;
    internal static int cost=200;
    [SerializeField] private TextMeshProUGUI TextMesh;
    public void OnClick()
    {
        if(cost<AttackMoneyBank.MoneyForTeam)
        {
            AttackMoneyBank.MoneyForTeam -= cost;
            lvl += 1;
            cost += 50;
        }
        TextMesh.text = $"{cost} Exp chanse{chanse + 4 * lvl}";

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
