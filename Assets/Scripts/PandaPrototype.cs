using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using JetBrains.Annotations;
using Unity.VisualScripting;

public class PandaPrototype : MonoBehaviour
{
    public static PandaPrototype instance;   //변수 선언부// 

    void Awake()
    {
        PandaPrototype.instance = this;  //변수 초기화부 // 

    }

    public GameObject panda;
    static int pandaNumber = 1;
    public GameObject[] pandatype;

    void Start()
    {
        print("here" + pandatype.Length);
        print(panda);
        // 저장된 판다 번호 있다면 번호 불러오기
        if (File.Exists(DataManager.instance.path + "Number"))
        {
            DataManager.instance.LoadND();
            pandaNumber = DataManager.instance.nowND.Number;
        }
    }

    public void AddPanda()
    {
        Debug.Log("AddPanda called");
        if (gameObject.GetComponent<InstallCheck>().CanInstall() == false) return;
        // if (gameObject.GetComponent<InstallCheck>().CanInstall() == false) return;
        GameObject newPanda = Instantiate(panda);
        print("h" + pandatype.Length);
        // 판다번호(종류,x,y) 저장
        DataManager.instance.nownumber = pandaNumber;
        pandaNumber++;
        

        Vector2 position = Camera.main.ScreenToWorldPoint(gameObject.transform.position);
        DataManager.instance.nowData.PandaX = gameObject.transform.position.x;
        DataManager.instance.nowData.PandaY = gameObject.transform.position.y;
        DataManager.instance.SaveData();
        // 판다 번호 저장
        DataManager.instance.SaveND(pandaNumber);


        newPanda.transform.position = gameObject.transform.position;
        Destroy(gameObject);
    }

    public void AddPanda(float x, float y, int number)
    {
        GameObject newPan = Instantiate(pandatype[number]);

        newPan.transform.position = new Vector3(x, y, 0);
    }



    public void DeletePanda()
    {
        Destroy(gameObject);
    }
}
