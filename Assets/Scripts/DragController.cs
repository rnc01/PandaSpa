using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // public GameObject PandaPrototype;

    public void OnBeginDrag(PointerEventData pointerEventData)
    {
        DragInput(pointerEventData);
    }

    public void OnDrag(PointerEventData pointerEventData)
    {
        DragInput(pointerEventData);
    }

    public void OnEndDrag(PointerEventData pointerEventData)
    {
    }

    private void DragInput(PointerEventData pointerEventData)
    {
        gameObject.transform.position = pointerEventData.position;
    }
}
