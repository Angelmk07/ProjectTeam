using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [SerializeField] private Button _batton;
    [SerializeField] private Image HealBar;

    

    private void Awake()
    {
        _batton.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        //HealBarCount +=0.1f;
        //Debug.Log($"Clicked! { HealBarCount}");
        HealBar.fillAmount += 0.025f;
        Time.timeScale += 0.001f;
    }
}
