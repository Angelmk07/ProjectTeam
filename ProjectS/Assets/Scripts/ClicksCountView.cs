using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicksCountView : MonoBehaviour
{
    [SerializeField] private ClicksBank _clicksBank;
    [SerializeField] private TextMashProUGUI _clicksCountFrield;
    [SerializeField] private TextMashProUGUI _clicksCountFrieldInShop;

    private void Update()
    {
        _clicksCountFrield.text = $"{_clicksBank.Clicks} clicks";
        _clicksCountFrieldInShop.text = $"{_clicksBank.Clicks} clicks";
    }
}
