using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardCheck : MonoBehaviour
{
    bool IsProces;
    AddQte key = new AddQte();
    List<int> keyInput = new List<int>();
    int i = 0;
    Event _event = new Event();
    private void Start()
    {
        _event.Pass += () => Debug.Log("Hit");
    }
    private void Update()
    {
        if (IsProces)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                keyInput.Add(0);
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                keyInput.Add(1);
            }
            else if(Input.GetKeyDown(KeyCode.S))
            {
                keyInput.Add(2);
            }
            else if(Input.GetKeyDown(KeyCode.D))
            {
                keyInput.Add(3);
            }


                _event.OnPass(keyInput, key.position);
            
           
            
                keyInput.Clear();
                i = 0;
            
        }
    }
    
}
