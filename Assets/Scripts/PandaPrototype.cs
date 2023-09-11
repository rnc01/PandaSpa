using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandaPrototype : MonoBehaviour
{
    public GameObject panda;
    public GameObject baby;
    static int pandaNumber = 1;
    public GameObject[] pandatype;


    public void AddPanda()
    {
        if (gameObject.transform.Find("Panda").gameObject.GetComponent<InstallCheck>().CanInstall() == false) return;
        GameObject newPanda = Instantiate(panda);
        
        // �Ǵٹ�ȣ(����,x,y) ����
        DataManager.instance.nownumber = pandaNumber;
        pandaNumber++;
        PandaSetting(panda);
        DataManager.instance.nowData.PandaX = newPanda.transform.position.x;
        DataManager.instance.nowData.PandaY = newPanda.transform.position.y;
        DataManager.instance.SaveData();

        // �Ǵ� �̸� �ٲ�
        //if (newPanda == baby)
        //{
        //    newPanda.name = "Baby" + BabyNumber;
        //    // �Ǵ� ��ġ ����
        //    PlayerPrefs.SetFloat("BabyX" + BabyNumber, newPanda.transform.position.x);
        //    PlayerPrefs.SetFloat("BabyY" + BabyNumber, newPanda.transform.position.y);
        //    BabyNumber++;
        //}

        Debug.Log(gameObject.transform.position);
        newPanda.transform.position = gameObject.transform.position;
        Debug.Log("addPanda");
        Debug.Log(newPanda.transform.position);

        Destroy(gameObject);
    }

    // �Ǵ��� ���� ����
    public void PandaSetting(GameObject panda)
    {
        for(int i = 0; i < pandatype.Length; i++)
        {
            if(panda == pandatype[i])
            {
                DataManager.instance.nowData.Panda = i;
            }
        }
    }

    public void AddPanda(float x, float y, int number)
    {
        GameObject newPanda = Instantiate(baby);

        newPanda.transform.position = new Vector3(x, y, 0);
    }

    public void DeletePanda()
    {
        Destroy(gameObject);
    }
}
