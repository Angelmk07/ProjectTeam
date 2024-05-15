using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IDragHandler
{
    public Vector3 mousepos;

    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition = eventData.pointerCurrentRaycast.screenPosition;
    }

    //private Vector3 GetMousePos()
    //{
    //    return Camera.main.ScreenToWorldPoint(transform.position);
    //}
    //private void OnMouseDown()
    //{
    //    mousepos = Input.mousePosition - GetMousePos();

    //}
    //private void OnMouseDrag()
    //{
    //    transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousepos);
    //}
}
