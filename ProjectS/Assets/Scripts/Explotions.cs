using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    [SerializeField] private Image Healbar;
    [SerializeField] private ClicksBank Exp;
    [SerializeField] private Slider EnemyBar_S;
    [SerializeField] private Button ExplorBomb;
    internal EnemyDamage EnemyDamage = new EnemyDamage();
    private bool DoExplore = false;
    internal bool CoolDown = true;
    private bool cancelebuy = true;
    private int cost = 500;
    private float explor_pover = 10f;



    public void ExploreTipe()
    {
        if ((Exp.Clicks - cost) > 0&& cancelebuy)
        {

            
            Exp.Clicks -= cost;
            DoExplore = true;
            cancelebuy = false;
        }
        if (DoExplore&& CoolDown)
        {
            StartCoroutine(EnableButtonAfterDelay());
        }

    }
    private IEnumerator EnableButtonAfterDelay()
    {
        CoolDown = false;
        EnemyDamage.EnemyHeatDamageVisualShow();
        EnemyDamage.InterectWithBar -= EnemyDamage.InterectWithBar / 2;
        yield return new WaitForSeconds(90f);
        CoolDown = true;
    }
}