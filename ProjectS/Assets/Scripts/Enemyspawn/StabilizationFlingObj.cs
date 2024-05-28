using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StabilizationFlingObj : MonoBehaviour
{
    [SerializeField] private GameObject Object1;
    [SerializeField] private GameObject Object2;
    [SerializeField] private GameObject Object3;
    [SerializeField] private GameObject Object4;
    ////private GameObject Object1Pos = null;
    ////private GameObject Object2Pos = null;
    ////private GameObject Object3Pos = null;
    ////private GameObject Object4Pos = null;
    ////void Start()
    ////{
    ////    Object1Pos.transform.rotation = Object1.transform.rotation;
    ////    Object2Pos.transform.rotation = Object2.transform.rotation;
    ////    Object3Pos.transform.rotation = Object3.transform.rotation;
    ////    Object4Pos.transform.rotation = Object4.transform.rotation;
    ////}

    // Update is called once per frame
    void Update()
    {
        Object1.transform.rotation = Quaternion.Euler(0,0,0);
        Object2.transform.rotation = Quaternion.Euler(0, 0, 0);
        Object3.transform.rotation = Quaternion.Euler(0, 0, 0);
        Object4.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
