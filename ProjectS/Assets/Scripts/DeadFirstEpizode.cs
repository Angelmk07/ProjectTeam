using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeadFirstEpizode : MonoBehaviour
{
    public void timeScale_1()
    {

        Clicker.Speed = 1f;
    }
    public void GoToMain()
    {
        
        SceneManager.LoadScene("MainScrin");


    }
}
