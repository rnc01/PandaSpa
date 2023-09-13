using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using JetBrains.Annotations;

public class PandaPrototype : MonoBehaviour
{
    public static PandaPrototype instance;   //���� �����// 

    void Awake()
    {
        PandaPrototype.instance = this;  //���� �ʱ�ȭ�� // 

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

        // �Ǵٹ�ȣ(����,x,y) ����
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

    // �Ǵ��� ���� ����
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
