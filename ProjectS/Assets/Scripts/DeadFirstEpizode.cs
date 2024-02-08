using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeadFirstEpizode : MonoBehaviour
{
    public static bool IsDead = false;
    [SerializeField] private Image ReturnHP;

    public void timeScale_1()
    {
        IsDead = true;
        Clicker.Speed = 1f;
        ReturnHP.fillAmount = 1f;
        Time.timeScale = 1f;
        Autoheal.isDoStop = true;
    }

}
