using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class StoreRed : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI M_text;
    [SerializeField]
    private TextMeshProUGUI Sale;

    void Start()
    {
        //gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (int.Parse(M_text.text) < int.Parse(Sale.text))
            gameObject.SetActive(true);
        else gameObject.SetActive(false);
            
    }
}
