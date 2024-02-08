using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class PoverActivBust : MonoBehaviour
{
    [SerializeField] private BrainHeats Pover;
    [SerializeField] private ClicksBank clicks;
    [SerializeField] private TextMeshProUGUI costText;
    [SerializeField] private TextMeshProUGUI stak;
    [SerializeField] private Image imagePower;
    public int stakValue=0;
    
    
    private int cost = 1000;
    private int costUp = 300;
    private float Poverbust = 0.01f;

    public void OnClick()
    {
        if (clicks.Clicks - cost > 0)
        {
            stakValue += 1;
            imagePower.color = Color.white;
            clicks.Clicks -= cost;
            Pover.Pover += Poverbust;
            cost += costUp;
            costText.text = $"{cost} Exp";
            stak.text = $"x{stakValue}";

        }

    }


}
