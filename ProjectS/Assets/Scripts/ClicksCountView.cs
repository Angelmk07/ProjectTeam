using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClicksCountView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _clicksCountFrield;
    [SerializeField] private TextMeshProUGUI _clicksCountFrieldInShop;
    [SerializeField] private ClicksBank _clicksBank;


    private void Update()
    {
        _clicksCountFrield.text = $"{_clicksBank.Clicks} clicks";
        _clicksCountFrieldInShop.text = $"{_clicksBank.Clicks} clicks";
    }
}
