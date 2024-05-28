using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveProgres : MonoBehaviour
{
    [SerializeField] private PlayerPrefsSave PlayerPrefsSave;
    public void ChangeScenStart()
    {
        PlayerPrefsSave.Save();
        GameManager.IsScenLoad = true;
        if (GameManager.GameMod == 0)
        {

            GameManager.GameMod = 1;
            SceneManager.LoadScene("Defence");

        }
        else
        {
            GameManager.GameMod = 1;
            SceneManager.LoadScene("Clikcer");
        }




    }


}
