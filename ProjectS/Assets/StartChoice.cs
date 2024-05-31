using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartChoice : MonoBehaviour
{
    public void OnClickClicker()
    {
        GameManager.GameMod = 0;
        SceneManager.LoadScene("Clikcer");
    }
    public void OnClickDefence()
    {
        GameManager.GameMod = 1;
        SceneManager.LoadScene("Defence");
    }
}
