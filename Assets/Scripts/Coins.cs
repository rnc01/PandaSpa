using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField]
    private int number;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinUpdate());
    }

    private IEnumerator CoinUpdate()
    {
        while (true)
        {
            UIManager.instance.IncreaseCoin(number);
            yield return new WaitForSecondsRealtime(1.0f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //GameManager.instance.IncreaseCoin(1);
        Debug.Log(number);
    }
}
