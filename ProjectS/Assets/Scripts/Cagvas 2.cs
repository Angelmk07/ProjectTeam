using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas2 : MonoBehaviour
{
    [SerializeField] private GameObject _Canvas2;

     public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            _Canvas2.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            _Canvas2.SetActive(false);
        }
    }
    //!_Canvas2.activeSelf
} 