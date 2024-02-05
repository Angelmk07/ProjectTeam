using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StopTime : MonoBehaviour
{



    public void OnClicStop()
    {
        

        Time.timeScale = 0;
    }
    public void OnClicReturn()
    {
        Time.timeScale = 1;
    }

    
}
