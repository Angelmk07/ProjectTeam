using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeadFirstEpizode : MonoBehaviour
{
    public void GoToMain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScrin");


    }
}
