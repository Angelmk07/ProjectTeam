using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LvlShow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI LvlClicker;
    [SerializeField] private TextMeshProUGUI LvlClickerMAx;
    [SerializeField] private TextMeshProUGUI LvlDefence;
    [SerializeField] private TextMeshProUGUI LvlDefenceMax;
    private void Update()
    {
        LvlClicker.text = $" {LvlPlayer.ClickerLvlOnScreen}";
        LvlDefence.text = $" {LvlPlayer.DefenceLvlOnScreen}";
        LvlClickerMAx.text = $" Max {LvlPlayer.ClickerLvl}";
        LvlDefenceMax.text = $" Max {LvlPlayer.DefenceLvl}";

    }
}
