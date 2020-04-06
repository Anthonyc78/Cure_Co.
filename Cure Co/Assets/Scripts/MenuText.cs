using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class ButtonControl, IPointerEnterHandler, IPointerExitHandler 
 {
     private GameObject childText = null; //  or make public and drag
void Start()
{
    Text text = GetComponentInChildren<Text>();
    if (text != null)
    {
        childText = text.gameObject;
        childText.SetActive(false);
    }
}
public void OnPointerEnter(EventSystems.PointerEventData eventData)
{
    childText.SetActive(true);
}
public void OnPointerExit(EventSystems.PointerEventData eventData)
{
    childText.SetActive(false);
}
 }

