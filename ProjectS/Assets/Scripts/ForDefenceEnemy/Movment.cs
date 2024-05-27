using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    [SerializeField] private float Speed = 2;
    void Update()
    {
        GameObject target = GameObject.FindGameObjectWithTag("Character");
        if (target == null) return;
        gameObject.transform.position += (target.transform.position-gameObject.transform.position ).normalized*Speed*Time.deltaTime;
    }
}
