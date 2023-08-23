using System.Collections;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    public bool isPositionDetermined = false;

    private void LateUpdate()
    {
        if(isPositionDetermined == false && Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = mousePosition;
        }
    }

    public void DeterminePosition()
    {
        isPositionDetermined = true;
        Debug.Log("determine");
    }
}
