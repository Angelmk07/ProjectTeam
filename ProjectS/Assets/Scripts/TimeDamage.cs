using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Image Healbar;
    [SerializeField] private GameObject EndScrin;

    void Update()
    {
        Healbar.fillAmount -=Time.deltaTime*0.1f;
        if (Healbar.fillAmount == 0)
        {
            
            Time.timeScale = 0;
            EndScrin.SetActive(true);
           

        }
    }
}
