using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Messege : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Message;

    public string text
    {
        get => Message.text;
        set => Message.text = value;
    }
    
}
