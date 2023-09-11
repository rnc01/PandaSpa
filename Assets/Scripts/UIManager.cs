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
        //pandaPrototype = GameObject.Find("PandaPrototype");
        //GameLoad();

        //Debug.Log(pp.PandaNumberGet());

        for (int i = 0; i < 1000; i++)
        {
            if (File.Exists(DataManager.instance.path + $"{i}"))
            {
                DataManager.instance.nownumber = i;
                DataManager.instance.LoadData();


            }
        }

    }

    //private void Update()
    //{
    //    GameSave();
    //}

    // 돈이 증가하여 텍스트로 출력하는 함수
    public void IncreaseCoin(int increase)
    {
        coin += 1 * increase;
        text.SetText(coin.ToString());
    }

    // 게임 요소 저장하는 함수
    //public void GameSave()
    //{
    //    PlayerPrefs.SetInt("Coin", coin);

    //    PlayerPrefs.Save();
    //}

    // 게임 요소 불러오는 함수
    //public void GameLoad()
    //{
    //    float PandaX;
    //    float PandaY;
    //    string Panda;
    //    int sCoin = PlayerPrefs.GetInt("Coin");
    //    for (int i = 0; i < pandaPrototype.GetComponent<PandaPrototype>().PandaNumberGet(); i++)
    //    {
    //        PandaX = PlayerPrefs.GetFloat("PandaX" + i);
    //        PandaY = PlayerPrefs.GetFloat("PandaY" + i);

    //        pandaPrototype.GetComponent<PandaPrototype>().AddPanda(PandaX, PandaY, this.Panda);
    //    }

    //    coin = sCoin;
    //}

    public void CreatePandaPrototype(GameObject pandaPrototype)
    {
        GameObject newPandaPrototype = Instantiate(Panda, GameObject.Find("Canvas").transform);
        newPandaPrototype.transform.position = new Vector3(800, 1000, -1);
    }
}
