using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroer : MonoBehaviour
{
    [SerializeField] private GameObject DestroerPrefub;
    private void Update()
    {
        DestroerPrefub.GetComponent<Image>();

    }
}
