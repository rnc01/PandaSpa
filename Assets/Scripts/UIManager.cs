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

    public void CreatePandaPrototype(GameObject pandaPrototype)
    {
        GameObject newPandaPrototype = Instantiate(pandaPrototype, GameObject.Find("Canvas").GetComponent<Transform>());
        pandaPrototype.transform.position = new Vector3(0, 0, -1);
    }
}
