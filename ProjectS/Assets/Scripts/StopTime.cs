using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StopTime : MonoBehaviour
{
    void Awake()
    {
        double TimeValue = Time.timeScale;
    }
    public float TimeValue { get;  }

    public void OnClicStop()
    {
        Time.timeScale = 0;
    }
    public void OnClicReturn()
    {
        Time.timeScale = TimeValue ;
    }

    
}
