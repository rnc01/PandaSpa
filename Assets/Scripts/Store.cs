using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Store : MonoBehaviour
{
    public GameObject StorePanel;

    // ���� ��ư Ŭ����
    public void OnClick()
    {
        // ���� ����� ��Ÿ����, ���� ��ư ���� ����
        if(StorePanel.transform.position.y > 130)
        {
            StorePanel.transform.position += new Vector3(0, -290f);
            transform.localScale = new Vector3(1,-1,1);
        }
        else if (StorePanel.transform.position.y < -130)
        {
            StorePanel.transform.position += new Vector3(0, 290f);
            transform.localScale = new Vector3(1, 1, 1);
        }


    }
}
