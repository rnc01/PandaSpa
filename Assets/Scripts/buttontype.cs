using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttontype : MonoBehaviour
{
    public BTNType currentType;
    public void OnBtnClick()
    {
        switch(currentType)
        {
            case BTNType.Continue:
                Debug.Log("�̾��ϱ�");
                break;
        }
    }
}
