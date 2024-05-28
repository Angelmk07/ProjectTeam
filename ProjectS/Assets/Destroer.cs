using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroer : MonoBehaviour
{
    [SerializeField] private GameObject DestroerPrefub;
    public void OnDeploying()
    {

        Camera.main.transform.DOShakeRotation(5f);
        Camera.main.transform.DOShakePosition(5f);
    }
}
