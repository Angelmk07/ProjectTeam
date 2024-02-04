using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [SerializeField] private Button _batton;
    [SerializeField] private TextMeshProUGUI _clicksCountField;

    private int _clicksCount;

    private void Awake()
    {
        _batton.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        _clicksCount++;
        Debug.Log($"Clicked! { _clicksCount}");
        _clicksCountField.text = _clicksCount.ToString();
    }
}
