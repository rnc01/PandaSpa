using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Store : MonoBehaviour
{
    public GameObject StorePanel;

    // 상점 버튼 클릭시
    public void OnClick()
    {
        // 상점 숨기기 나타내기, 상점 버튼 상하 반전
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
