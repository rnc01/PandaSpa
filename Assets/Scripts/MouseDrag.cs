using System.Collections;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public void MouseDragCoroutine()
    {
        while(Input.GetMouseButtonDown(0))
        {
            Vector2 mouseDragPosition =  new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldObjectPosition =  Camera.main.ScreenToWorldPoint(mouseDragPosition);
            this.transform.position = worldObjectPosition;
            Debug.Log(1);
            // yield return null;
        }
    }
}
