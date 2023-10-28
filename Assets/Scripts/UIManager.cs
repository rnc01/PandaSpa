using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class UIManager : MonoBehaviour
{
    public GameObject Panda;
    public GameObject pandaPrototype;

    public GameObject[] pandatype;

    public AudioSource bgmPlayer;

    // Money Text
    public static UIManager instance = null;

    [SerializeField]
    private TextMeshProUGUI text;

    public int coin = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        bgmPlayer.Play();

        for (int i = 0; i < 1000; i++)
        {
            if (File.Exists(DataManager.instance.path + $"{i}"))
            {
                DataManager.instance.nownumber = i;
                DataManager.instance.LoadData();
                PandaGetting();

            }
        }

        if (File.Exists(DataManager.instance.path + "Coin"))
        {
            DataManager.instance.LoadDD();
            coin = DataManager.instance.nowDD.Coin;

        }

    }


    // 돈이 증가하여 텍스트로 출력하는 함수
    public void IncreaseCoin(int increase)
    {
        coin += 1 * increase;
        text.SetText(coin.ToString());
    }

    public void CreatePandaPrototype(GameObject pandaPrototype)
    {
        GameObject newPandaPrototype = Instantiate(Panda, GameObject.Find("Canvas").transform);
        newPandaPrototype.transform.position = new Vector3(800, 1000, -1);
    }

    // 저장된 판다 불러오기 실현
    public void PandaGetting()
    {
        int panda = DataManager.instance.nowData.Panda;
        float x = DataManager.instance.nowData.PandaX;
        float y = DataManager.instance.nowData.PandaY;

        PandaPrototype.instance.AddPanda(x, y, panda);
    }
}
