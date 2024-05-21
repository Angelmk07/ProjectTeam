using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bullet : MonoBehaviour, IPointerClickHandler
{
    float bulletPov = 0.2f;
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        InteractWhisPLayerBar.ChangeBar(-bulletPov);
    }

}
