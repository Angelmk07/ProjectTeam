using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor.Playables;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public Vector2 mousepos;
    private Vector2 vmousepos2;
    // rec transform utility scrinpoint to local
    public RectTransform RectTransform;
    public void OnDrag(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(RectTransform, eventData.position, Camera.main, out mousepos);
        RectTransform.localPosition = (mousepos + vmousepos2);


        if (Input.GetMouseButtonUp(0) && IsDeploing)
        {

            enemyDamage.EnemyHeatBygranade();
            enemyDamage.InteractWhithBar -= enemyDamage.InteractWhithBar / 2;
            IsDeploing = false;
        }
    }

    public Vector3 place;

    internal static bool IsDeploing;
    internal static bool IsOntarget;
    internal bool IsStay;
    EnemyDamage enemyDamage = new EnemyDamage();

    private void Start()
    {
        place = gameObject.transform.position;
    }
 


    public void OnEndDrag(PointerEventData eventData)
    {
        if (!IsOntarget)
        {
            //transform.position = place;

        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(RectTransform, eventData.position, Camera.main, out mousepos);
        vmousepos2 = RectTransform.anchoredPosition - mousepos;
    }
}
