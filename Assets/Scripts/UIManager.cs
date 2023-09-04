using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;



public class UIManager : MonoBehaviour
{
    public GameObject baby_panda_prototype;

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

    }

    // 돈이 증가하여 텍스트로 출력하는 함수
    public void IncreaseCoin(int increase)
    {
        coin += 1 * increase;
        text.SetText(coin.ToString());
    }

    // 게임 요소 저장하는 함수
    public void GameSave()
    {
        PlayerPrefs.SetInt("Coin", coin);
        //PlayerPrefs.SetFloat("PandaX", baby_panda_prototype.transform.position.x);
        //PlayerPrefs.SetFloat("PandaY", baby_panda_prototype.transform.position.y);
        PlayerPrefs.Save();
    }

    public void GameLoad()
    {
        int sCoin = PlayerPrefs.GetInt("Coin");

        coin = sCoin;
    }

    public void CreatePandaPrototype(GameObject pandaPrototype)
    {
        GameObject newPandaPrototype = Instantiate(pandaPrototype, GameObject.Find("Canvas").GetComponent<Transform>());
        pandaPrototype.transform.position = new Vector3(800, 1000, -1);
    }
}
