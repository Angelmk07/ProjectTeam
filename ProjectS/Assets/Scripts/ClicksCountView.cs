using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicksCountView : MonoBehaviour
{
    [SerializeField] private ClicksBank _clicksBank;
    [SerializeField] private TextMashProUGUI _clicksCountFrield;

    private void Update()
    {
        _clicksCountFrield.text = $"{_clicksBank.Clicks} clicks";
    }
}
