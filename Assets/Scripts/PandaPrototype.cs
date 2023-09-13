using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using JetBrains.Annotations;

public class PandaPrototype : MonoBehaviour
{
    public static PandaPrototype instance;   //변수 선언부// 

    void Awake()
    {
        PandaPrototype.instance = this;  //변수 초기화부 // 

    }

    public GameObject panda;
    public GameObject baby;
    static int pandaNumber = 1;
    public GameObject[] pandatype;
    public int a = 2;

    void Start()
    {

    }

    public void AddPanda()
    {
        if (gameObject.GetComponent<InstallCheck>().CanInstall() == false) return;
        GameObject newPanda = Instantiate(panda);

        // 판다번호(종류,x,y) 저장
        DataManager.instance.nownumber = pandaNumber;
        pandaNumber++;
        PandaSetting(panda);
        DataManager.instance.nowData.PandaX = gameObject.transform.position.x;
        DataManager.instance.nowData.PandaY = gameObject.transform.position.y;
        DataManager.instance.SaveData();


        newPanda.transform.position = gameObject.transform.position;
        Destroy(gameObject);
    }

    public void AddPanda(float x, float y, int number)
    {
        GameObject newPan = Instantiate(pandatype[number]);

        newPan.transform.position = new Vector3(x, y, 0);
    }

    // 판다의 종류 저장
    public void PandaSetting(GameObject panda)
    {
        for (int i = 0; i < pandatype.Length; i++)
        {
            if (panda == pandatype[i])
            {
                DataManager.instance.nowData.Panda = i;
            }
        }
    }

    public void DeletePanda()
    {
        Destroy(gameObject);
    }
}
