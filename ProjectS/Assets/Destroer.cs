using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Destroer : MonoBehaviour,IDragHandler,IEndDragHandler
{
    [SerializeField] private GameObject DestroerPrefub;
    [SerializeField] private GameObject canvas;
    public void OnDeploying()
    {

        Camera.main.transform.DOShakeRotation(5f,20);
        //Camera.main.transform.DOShakePosition(5f,20);
        Collider2D[] collider2Ds = Physics2D.OverlapCircleAll(transform.position, 60);

        Instantiate(DestroerPrefub, canvas.transform.position,  Quaternion.identity);
        foreach (Collider2D collider in collider2Ds)
        {
            if (collider.gameObject.tag == "GroundEnemy" || collider.gameObject.tag == "Flying")
            {
                collider.GetComponent<EnemyDamage>().InteractWhithBar -= 70000f;
            }

        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 Poscursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(Poscursor.x, Poscursor.y, 0);
        Vector3 vector = transform.localPosition;
        vector.z = 0;
        transform.localPosition = vector;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        OnDeploying();
        Destroy(gameObject);
    }
}
