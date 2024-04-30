using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowAttackBank : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI attackBank;
    void Update()
    {
        attackBank.text = $"{AttackMoneyBank.MoneyForTeam}";
    }
}
