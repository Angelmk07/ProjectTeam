using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CopyText : MonoBehaviour
{
    public GameObject text;

    public void Start()
    {
        Instantiate(text, new Vector3(206, -818, 0), Quaternion.Euler(0, 0, 0));
    }
}
