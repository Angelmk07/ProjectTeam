using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeadFirstEpizode : MonoBehaviour
{
    public void GoToMain()
    {
        SceneManager.LoadScene("MainScrin");
        Time.timeScale = 1;

    }
}
