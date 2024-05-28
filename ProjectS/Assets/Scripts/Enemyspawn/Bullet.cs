using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TextCore.Text;

public class Bullet : MonoBehaviour
{
    float bulletPov = 0.2f;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Character")
        {
            Destroy(gameObject);
            InteractWhisPLayerBar.ChangeBar(-bulletPov);
        }

    }
    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }
    }
}
