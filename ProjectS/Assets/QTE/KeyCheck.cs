using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyCheck 

{
    int position=0;
    public UnityEvent OnMisstake { get; } = new UnityEvent();
    public UnityEvent OnPass { get; } = new UnityEvent();
    private List<KeyCode> keysEnter = new List<KeyCode>();
    public KeyCheck(IEnumerable<KeyCode> keyCodes)
    {
        keysEnter = new List<KeyCode>(keyCodes);
    }

    public void  setOrder(IEnumerable<KeyCode> keyCodes)
    {
        keysEnter.Clear();
        keysEnter.AddRange(keyCodes);
        int position = 0;
    }
    public bool InputKey(KeyCode keyCode)
    {

        if (keysEnter[position]== keyCode)
        {
            position++;
            if(position >= keysEnter.Count)
            {
                OnPass.Invoke();
            }
            return true;

        }
        OnMisstake.Invoke();

        position = 0;
        return false;
    }
}
