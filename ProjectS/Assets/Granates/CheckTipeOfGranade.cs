using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTipeOfGranade : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButtonUp(0) && collision.tag == ("Explosive")&&collision.name == "ExplosiveGranade")
        {

            TakeAndDrop.IsDeploingExplosiv = true;
        }
        else if (Input.GetMouseButtonUp(0)&& collision.tag == ("Explosive")&&collision.name == "FireGranade")
        {
            TakeAndDrop.IsDeploingFire = true;
        }
        if (collision.tag == ("Explosive"))
        {
            TakeAndDrop.IsOntarget = true;
            TakeAndDrop.HittenObj = gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == ("Explosive"))
        {
            TakeAndDrop.IsOntarget = false;
  
        }
    }

}
