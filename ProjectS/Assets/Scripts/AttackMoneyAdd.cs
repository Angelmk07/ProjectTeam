using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackMoneyAdd : MonoBehaviour
{
    private static int _AttackPointAdd;
    public static int AttackPointAdd
    {
        get { return _AttackPointAdd; }
        set { _AttackPointAdd = value; }
    }

    public void OnClick()
    {
        AttackMoneyBank.MoneyForTeam += AttackPointAdd;
    }
}

