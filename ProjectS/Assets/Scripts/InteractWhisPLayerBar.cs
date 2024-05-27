using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractWhisPLayerBar : MonoBehaviour
{
    [SerializeField] private static Image Healbar ;
    [SerializeField] private static Image HealBar_2 ;
    public static float HealbarUse { get => Healbar.fillAmount; set => Healbar.fillAmount = value; }
    public static float HealbarUse2 { get => HealBar_2.fillAmount; set => HealBar_2.fillAmount = value; }

    private void Start()
    {
        Healbar = GameObject.Find("Healnum").GetComponent<Image>();
        HealBar_2 = GameObject.Find("Healnum_2").GetComponent<Image>();
    }
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
