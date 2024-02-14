using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    [SerializeField] private Image Healbar;
    [SerializeField] private ClicksBank Exp;
    private bool DoExplore = false;
    private bool cancelebuy = true;
    private int cost = 500;


    public void Start()
    {
        if ((Exp.Clicks - cost) > 0&& cancelebuy)
        {

            
            Exp.Clicks -= cost;
            DoExplore = true;
            cancelebuy = false;
        }
        if (DoExplore)
        {
            StartCoroutine(EnableButtonAfterDelay());
        }

    }
    private IEnumerator EnableButtonAfterDelay()
    {
       
        Healbar.fillAmount -= 0.5f;
        yield return new WaitForSeconds(3f);

    }
}