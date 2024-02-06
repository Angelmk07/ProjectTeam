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
    [SerializeField] private Image HealBar_2;
    [SerializeField] public float SpeedChange = 0.01f;
    private float HealBar_2Change = 0.035f;
    private float HealBarChange = 0.04f;
    private void Awake()
    {
        _batton.onClick.AddListener(OnClick);
        Time.timeScale = 1;
    }
    public void OnClick()
    {
        //HealBarCount +=0.1f;
        //Debug.Log($"Clicked! { HealBarCount}");

        Speed += SpeedChange;
        HealBar.fillAmount += HealBarChange;
        if (HealBar.fillAmount+HealBarChange>=1)
        {
            
            HealBar_2.fillAmount = HealBar_2.fillAmount+HealBar_2Change-(1f-HealBar.fillAmount);
        }
        /*else
        {
            HealBar.fillAmount += HealBarChange;
        }*/
    }
}
