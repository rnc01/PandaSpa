using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    [SerializeField]
    private TextMeshProUGUI text;

    private int coin = 0;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void IncreaseCoin(int increase)
    {
        coin += 1 * increase;
        text.SetText(coin.ToString());
    }

}
