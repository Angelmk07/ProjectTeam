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
    [SerializeField] public static float Speed = 1f;

    

    private void Awake()
    {
        _batton.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        //HealBarCount +=0.1f;
        //Debug.Log($"Clicked! { HealBarCount}");
        HealBar.fillAmount += 0.025f;
        Speed += 1f;
        
    }
}
