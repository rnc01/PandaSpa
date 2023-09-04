using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;



public class UIManager : MonoBehaviour
{
    public GameObject baby_panda_prototype;
    public GameObject baby;
    public GameObject pandaprototype;

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

    private void Start()
    {
        pandaprototype = GameObject.Find("PandaPrototype");
        GameLoad();
        //Debug.Log(pp.PandaNumberGet());
    }

    private void Update()
    {
        GameSave();
    }

    // ���� �����Ͽ� �ؽ�Ʈ�� ����ϴ� �Լ�
    public void IncreaseCoin(int increase)
    {
        coin += 1 * increase;
        text.SetText(coin.ToString());
    }

    // ���� ��� �����ϴ� �Լ�
    public void GameSave()
    {
        PlayerPrefs.SetInt("Coin", coin);

        PlayerPrefs.Save();
    }

    // ���� ��� �ҷ����� �Լ�
    public void GameLoad()
    {
        float PandaX;
        float PandaY;
        string Panda;
        int sCoin = PlayerPrefs.GetInt("Coin");
        for (int i = 0; i < pandaprototype.GetComponent<PandaPrototype>().PandaNumberGet(); i++)
        {
            PandaX = PlayerPrefs.GetFloat("PandaX" + i);
            PandaY = PlayerPrefs.GetFloat("PandaY" + i);

            pandaprototype.GetComponent<PandaPrototype>().AddPanda(PandaX, PandaY, baby);
        }
        
        coin = sCoin;

    }

    public void CreatePandaPrototype(GameObject pandaPrototype)
    {
        GameObject newPandaPrototype = Instantiate(pandaPrototype, GameObject.Find("Canvas").GetComponent<Transform>());
        pandaPrototype.transform.position = new Vector3(800, 1000, -1);
    }
}
