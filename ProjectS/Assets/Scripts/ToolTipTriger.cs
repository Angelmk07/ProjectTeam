using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToolTipTriger : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    public string tooltipmessage;
    public ToolTip toolTip;

   
    public void OnPointerEnter(PointerEventData eventData)
    {
        toolTip.ShowToolTip(tooltipmessage);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        toolTip.HideToolTip();
    }
}
