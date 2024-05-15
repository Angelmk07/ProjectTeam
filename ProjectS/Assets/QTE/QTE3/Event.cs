using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Event
{
    public event Action Damage;
    public event Action Pass;
    
    public void OnTimeEnd()
    {
        Damage();
    }
    //public void OnPass(int count,int truePosition)
    //{
    //    if (count == truePosition)
    //    {
    //        Pass();
    //    }

    //}
    public void OnPass()
    {


            Pass();


    }
}
