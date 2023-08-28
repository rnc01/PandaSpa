using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    public GameObject baby_panda_prototype;

    // Money Text
    public static UIManager instance = null;

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

    public void AddBabyPanda()
    {
        GameObject newBabyPanda = Instantiate(baby_panda_prototype);
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = -1;
        newBabyPanda.transform.position = newPosition;
    }
}
