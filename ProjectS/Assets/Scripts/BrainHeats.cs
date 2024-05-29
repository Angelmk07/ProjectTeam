using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainHeats : MonoBehaviour
{
    private static float _pover = 0.2f;

    public static float Pover
    {
        get => _pover;
        set => _pover = value;

    }
}
