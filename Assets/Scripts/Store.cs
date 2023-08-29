using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Store : MonoBehaviour
{
    public GameObject StorePanel;
    public void OnClick()
    {
        if(StorePanel.transform.position.y > 130)
            StorePanel.transform.position += new Vector3(0, -290f);
        else if (StorePanel.transform.position.y < -130)
            StorePanel.transform.position += new Vector3(0, 290f);

    }
}
