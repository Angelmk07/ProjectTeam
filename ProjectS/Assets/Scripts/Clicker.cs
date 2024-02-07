using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _clicksBankView;
    [SerializeField] private Button _batton;
    [SerializeField] private Image HealBar;
    [SerializeField] public static float Speed = 1f;
    [SerializeField] private Image HealBar_2;
    [SerializeField] public float SpeedChange = 0.01f;
    [SerializeField] private ClicksBank _clicksBank;


    private float HealBar_2Change = 0.035f;
    private float HealBarChange = 0.04f;
    private void Awake()
    {
        _batton.onClick.AddListener(Update);
        Time.timeScale = 1;
    }

    public void OnClick()
    {
        _clicksBankView.text = $"Exp {_clicksBank.Clicks++} " ;

        
        bool _IsHaveHeal = AddHealbar.IsHealHave;
        //Speed += SpeedChange;

        if (_IsHaveHeal)
        {
            HealBar.fillAmount += HealBarChange;
            if (HealBar.fillAmount+HealBarChange>=1)
            {
            
                HealBar_2.fillAmount = HealBar_2.fillAmount+HealBar_2Change-(1f-HealBar.fillAmount);
            }
        }
        else
        {
            HealBar.fillAmount += HealBarChange;
        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _clicksBankView.text = $"Exp {_clicksBank.Clicks++} " ;

        
            bool _IsHaveHeal = AddHealbar.IsHealHave;
            Speed += SpeedChange;

            if (_IsHaveHeal)
            {
                HealBar.fillAmount += HealBarChange;
                if (HealBar.fillAmount+HealBarChange>=1)
                {
            
                    HealBar_2.fillAmount = HealBar_2.fillAmount+HealBar_2Change-(1f-HealBar.fillAmount);
                }
            }
            else
            {
                HealBar.fillAmount += HealBarChange;
            }

        }

        
    }
}
