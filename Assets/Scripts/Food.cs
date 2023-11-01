using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int level;
    public int earingCoin;
    public SellerPanda sellerPanda;

    public void Start()
    {
        sellerPanda = GameObject.Find("sellerPanda").GetComponent<SellerPanda>();
    }

    public void Clicked()
    {
            sellerPanda.onFood = false;
            UIManager.instance.IncreaseCoin(earingCoin);
            Destroy(gameObject);
    }
}
