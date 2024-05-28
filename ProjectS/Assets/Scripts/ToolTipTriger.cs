using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ToolTipTriger : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] private TextMeshProUGUI _toolText;
    public string tooltipmessage;
    public GameObject _toolPanel;
    


    public void OnPointerEnter(PointerEventData eventData)
    {
        _toolText.text = tooltipmessage;
        _toolPanel.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _toolPanel.SetActive(false);
    }
}
