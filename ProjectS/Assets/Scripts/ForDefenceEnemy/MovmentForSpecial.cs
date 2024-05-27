using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentForSpecial : MonoBehaviour
{
    [SerializeField] private float Speed = 2;
    [SerializeField] private float distansce = 30;
    void Update()
    {


        GameObject target = GameObject.FindGameObjectWithTag("Character");
       
        if (Vector2.Distance(target.transform.position,transform.position)> distansce)
        {
            if (target == null) return;
            gameObject.transform.position += (target.transform.position - gameObject.transform.position).normalized * Speed * Time.deltaTime;
        }
    }
}
