using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBuy : MonoBehaviour
{
    ClicksBank ClicksBank;
    private int cost= 700000;
    [SerializeField] private GameObject Destroer;
    internal static bool HaveDestroer = false;

    public void Onclick()
    {
        if(ClicksBank.Clicks- cost >= 0&&!HaveDestroer )
        {
            Destroer.SetActive(true);
            HaveDestroer = true;
            Destroer.SetActive(true);
        }
        if (HaveDestroer)
        {
            gameObject.SetActive(false);
        }
    }


}
