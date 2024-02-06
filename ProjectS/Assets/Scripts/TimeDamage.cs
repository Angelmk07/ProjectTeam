using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Image Healbar;
    [SerializeField] private GameObject EndScrin;
    [SerializeField] private Image HealBar_2;
    void Update()
    {
        float courrentSpeed = Clicker.Speed;
        if (HealBar_2.fillAmount<=0)
        {
            Healbar.fillAmount -=Time.deltaTime*0.1f*courrentSpeed;
        }
        else
        {
            HealBar_2.fillAmount -=Time.deltaTime*0.1f*courrentSpeed;
        }
        
        if (Healbar.fillAmount == 0)
        {
            
            Time.timeScale = 0;
            EndScrin.SetActive(true);
           

        }
    }
}
