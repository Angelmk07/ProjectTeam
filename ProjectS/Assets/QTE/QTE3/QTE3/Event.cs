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
    public void OnPass(List<int> user, List<int> systemGenerate)
    {

        if(user.Count == systemGenerate.Count)
        {
            for(int i=0; i < user.Count; i++)
            {
                if(user[i] == systemGenerate[i])
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
            Pass();
        }




    }
    public void Time()
    {

    }
}
