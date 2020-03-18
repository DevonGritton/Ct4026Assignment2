using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class sliderScript : MonoBehaviour, IEndDragHandler, IDragHandler
{
    public Plunger Plungers;
    
    public void OnEndDrag(PointerEventData data)
    {
        Plungers.DragEnd = true;
    }
    public void OnDrag(PointerEventData Drag)
    {
        Plungers.change = true;
    }
}
