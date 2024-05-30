using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttackBust : MonoBehaviour
{
    [SerializeField] private TextMashProUGUI text;
    internal static int cost = 700;

    [SerializeField]private ClicksBank Clicks;
    public void Click()
    {
        if (Clicks.Clicks-cost >= 0)
        {
            Clicks.Clicks -= cost;
            BrainHeats.Pover += 0.5f;
            cost += 300;
            text.text = $"{cost} Exp";
        }

    }


}
