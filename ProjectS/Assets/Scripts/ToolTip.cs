using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour
{
   public GameObject _toolPanel;
   public Text _toolText;

   public void ShowToolTip(string message)
   {
      _toolPanel.SetActive(true);
      _toolText.text = message;
   }

   public void HideToolTip()
   {
      _toolPanel.SetActive(false);
   }
}
