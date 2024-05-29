
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScen : MonoBehaviour
{

    public void SwitchToClicker()
    {
        if(GameManager.GameMod == 0)
            return;
        
        else
            SceneManager.LoadScene("Clikcer");



       
    }
    public void SwitchToDefence()
    {
        if (GameManager.GameMod == 1)
            return;
        else
            SceneManager.LoadScene("Defence");
    }   
}