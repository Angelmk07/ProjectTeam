using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyExplosiv : MonoBehaviour
{
    internal static bool HaveItem = false;
    [SerializeField] private ClicksBank ClicksBank;
    [SerializeField] private GameObject Item;
    int cost=1250;
    public void Click()
    {
        if(ClicksBank.Clicks - cost >= 0&& !HaveItem)
        {
            ClicksBank.Clicks -= cost;
            HaveItem = true;
            Item.SetActive(true);
        }
        if(HaveItem)
        {
            gameObject.SetActive(false);
        }
    }


}
