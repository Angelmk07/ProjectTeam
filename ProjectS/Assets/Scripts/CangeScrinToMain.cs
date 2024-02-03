using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CangeScrinToMain : MonoBehaviour
{
    
    public void OpenMainScrin()
    {
        SceneManager.LoadScene("MainScrin");
    }
}
