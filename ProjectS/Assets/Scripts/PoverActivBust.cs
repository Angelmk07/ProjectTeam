using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class PoverActivBust : MonoBehaviour
{
    [SerializeField] private ClicksBank clicks;
    [SerializeField] private TextMeshProUGUI costText;
    [SerializeField] private TextMeshProUGUI stak;
    [SerializeField] private Image imagePower;
    internal  int stakValue=0;
    internal  int cost = 300;
    private int costUp = 50;
    private float Poverbust = 0.4f;

    public void OnClick()
    {
        if (clicks.Clicks - cost > 0)
        {
            stakValue += 1;
            imagePower.color = Color.white;
            clicks.Clicks -= cost;
            BrainHeats.Pover += Poverbust;
            cost += costUp;


        }
        costText.text = $"{cost} Exp";
        stak.text = $"x{stakValue}";
    }


}
