using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadChanges : MonoBehaviour
{
     private PlayerPrefsSave playerPrefsSave;
    void Start()
    {
        if (GameManager.IsScenLoad)
        {
            playerPrefsSave = gameObject.GetComponent<PlayerPrefsSave>();
            playerPrefsSave.Load();
        }

        
    }


}
