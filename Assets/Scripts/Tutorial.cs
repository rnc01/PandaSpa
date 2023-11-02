using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject WelcomePanel;
    public GameObject TStep1Panel;
    public void OnClick()
    {
        UIManager.instance.IncreaseCoin(2000);
        WelcomePanel.SetActive(false);
        TStep1Panel.SetActive(true);
    }
    
    
}
