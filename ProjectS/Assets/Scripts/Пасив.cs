using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Пасив : MonoBehaviour
{
    [SerializeField] private Image Healbar;
    [SerializeField] private GameObject EndScrin;
    [SerializeField] private GameObject Cavas;
    [SerializeField] private Image HealBar_2;

    private void Start()
    {
        Invoke("TestMethod1", 1.5f);
    }
    void Update()
    {
        bool _IsHaveHeal = AddHealbar.IsHealHave;
        if (_IsHaveHeal)
        {
            float courrentSpeed = Clicker.Speed;
            if (HealBar_2.fillAmount <= 0)
            {
                Healbar.fillAmount += Time.deltaTime * 0.4f * courrentSpeed;
            }
            else
            {
                HealBar_2.fillAmount += Time.deltaTime * 0.4f * courrentSpeed;
            }
        }
        else
        {
            float courrentSpeed = Clicker.Speed;
            Healbar.fillAmount += Time.deltaTime * 0.4f * courrentSpeed;
        }

        if (Healbar.fillAmount == 0)
        {

            Time.timeScale = 0;
            Cavas.SetActive(false);
            EndScrin.SetActive(true);


        }
    }
}