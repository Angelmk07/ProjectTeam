using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractWhisPLayerBar : MonoBehaviour
{
    [SerializeField] private static Image Healbar;
    [SerializeField] private static Image HealBar_2;


    public static void ChangeBar(float value)
    {

                if (HealBar_2.fillAmount <= 0)
                {
                    Healbar.fillAmount += value;
                }
                else
                {
                    HealBar_2.fillAmount += value;
                }
            

        
    }
}
