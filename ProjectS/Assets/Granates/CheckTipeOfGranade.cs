using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTipeOfGranade : MonoBehaviour
{


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonUp(0)&&other.tag==("Explosive"))
        {
            TakeAndDrop.IsDeploing = true;
        }
        if ( other.tag == ("Explosive"))
        {
            TakeAndDrop.IsOntarget = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Explosive"))
        {
            TakeAndDrop.IsOntarget = false;
        }
    }
}
