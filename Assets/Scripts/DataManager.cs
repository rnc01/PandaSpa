using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Data
{
    public int Panda;
    public float PandaX;
    public float PandaY;
}
public class DefaultData
{
    public int Coin;
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public Data nowData = new Data();
    public DefaultData nowDD = new DefaultData();

    public string path;
    public int nownumber;

    private void Awake()
    {
        #region ΩÃ±€≈Ê
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(instance.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        #endregion

        path = Application.persistentDataPath + "/save";
    }
    private void Start()
    {
        print(path);
    }
    // Update is called once per frame
    void Update()
    {
        SaveDD();
    }

    public void SaveData()
    {
        string data = JsonUtility.ToJson(nowData);
        
        File.WriteAllText(path + nownumber.ToString(), data);
    }

    public void LoadData()
    {
        string data = File.ReadAllText(path + nownumber.ToString());
        nowData = JsonUtility.FromJson<Data>(data);
    }

    public void SaveDD()
    {
        nowDD.Coin = UIManager.instance.coin;

        string dd = JsonUtility.ToJson(nowDD);
        File.WriteAllText(path + "Coin", dd);
    }
    public void LoadDD()
    {
        string dd = File.ReadAllText(path + "Coin");
        nowDD = JsonUtility.FromJson<DefaultData>(dd);
    }
}
