using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    [SerializeField] private Image Healbar;
    [SerializeField] private ClicksBank Exp;
    [SerializeField] private Button _batton;
    private bool Isbuy = true;
    public static bool IsbuyDo = false;
    private int cost = 500;
    private bool isButtonActive;

    public void Start()
    {
        if ((Exp.Clicks - cost) > 0 && Isbuy)
        {
            Isbuy = false;
            StartCoroutine(EnableButtonAfterDelay());
            Exp.Clicks -= cost;
            IsbuyDo = true;
        }

    }
    private IEnumerator EnableButtonAfterDelay()
    {
        isButtonActive = true;
        _batton.interactable = true;
        bool _IsHaveHeal = AddHealbar.IsHealHave;
        if (_IsHaveHeal)
        {
            Healbar.fillAmount -= 0.5f;
        }
        yield return new WaitForSeconds(3f);
    }
}
