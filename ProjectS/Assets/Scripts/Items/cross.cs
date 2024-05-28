using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cross : MonoBehaviour
{
    float power = 0.02f;
    void Update()
    {
        
    }
    IEnumerator CrossDamage()
    {
        yield return new WaitForSeconds(2f);
        //GameObject.FindFirstObjectByType

    }
}
