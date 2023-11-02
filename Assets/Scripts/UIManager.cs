using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class UIManager : MonoBehaviour
{
    public GameObject Panda;
    // public GameObject pandaPrototype;
    public GameObject WelcomePanel;
    public GameObject TStep2Panel;
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
            instance = this;
        else
            Destroy(gameObject);
    }

    public void StartTutorial()
    {
        if (File.Exists(DataManager.instance.path + "1"))
        {
            WelcomePanel.SetActive(false);
        }
        else { WelcomePanel.SetActive(true); }
    }

    void Start()
    {

        print("here");
        // ���Ͽ� ����� �Ǵٵ� �ҷ�����
        for (int i = 0; i < 1000; i++)
        {
            if (File.Exists(DataManager.instance.path + $"{i}"))
            {
                print(DataManager.instance.path);
                DataManager.instance.nownumber = i;
                DataManager.instance.LoadData();
                PandaGetting();

            }
        }
        // ����� ������ �ִٸ� ���� �ҷ�����
        if (File.Exists(DataManager.instance.path + "Coin"))
        {
            DataManager.instance.LoadDD();
            coin = DataManager.instance.nowDD.Coin;

        }
    }

    // ���� �����Ͽ� �ؽ�Ʈ�� ����ϴ� �Լ�
    public void IncreaseCoin(int increase)
    {
        coin += 1 * increase;
        text.SetText(coin.ToString());
    }

    public void DecreaseCoin(int increase)
    {
        coin -= 1 * increase;
        text.SetText(coin.ToString());
    }

    public void CreatePandaPrototype(GameObject pandaPrototype)
    {
        GameObject newPandaPrototype = Instantiate(pandaPrototype, GameObject.Find("Ingame").transform);
        newPandaPrototype.transform.position = new Vector3(800, 1000, -1);

        if(TStep2Panel.activeSelf == true) TStep2Panel.SetActive(false);
    }

    // ����� �Ǵ� �ҷ����� ����
    public void PandaGetting()
    {
        int panda = DataManager.instance.nowData.Panda;
        float x = DataManager.instance.nowData.PandaX;
        float y = DataManager.instance.nowData.PandaY;

        PandaPrototype.instance.AddPanda(x, y, panda);
    }
}
