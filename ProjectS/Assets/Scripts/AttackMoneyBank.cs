using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMoneyBank : MonoBehaviour
{
    private static int attackPoint;
    public static int MoneyForTeam
    {
        get { return attackPoint; }
        set { attackPoint = value; }
    }
}
