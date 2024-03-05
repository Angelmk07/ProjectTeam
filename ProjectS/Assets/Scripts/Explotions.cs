using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    [SerializeField] private Image Healbar;
    [SerializeField] private ClicksBank Exp;
    [SerializeField] private Slider EnemyBar_S;
    [SerializeField] private Button ExplorBomb;

    private bool DoExplore = false;
    private bool cancelebuy = true;
    private int cost = 500;
    private float explor_pover = 10f;



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
        ExplorBomb.interactable = false;
        Healbar.fillAmount -= explor_pover;
        EnemyBar_S.value -= explor_pover;
        yield return new WaitForSeconds(90f);
        ExplorBomb.interactable = true;
    }
}