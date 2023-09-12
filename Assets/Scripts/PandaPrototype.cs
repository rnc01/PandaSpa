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
        if (gameObject.GetComponent<InstallCheck>().CanInstall() == false) return;
        GameObject newPanda = Instantiate(panda);
        
        // 20~25 오류나서 임시로 주석처리 해뒀습니다 - 홍식
        // 판다번호(종류,x,y) 저장
        //DataManager.instance.nownumber = pandaNumber;
        //pandaNumber++;
        //PandaSetting(panda);
        //DataManager.instance.nowData.PandaX = newPanda.transform.position.x;
        //DataManager.instance.nowData.PandaY = newPanda.transform.position.y;
        //DataManager.instance.SaveData();

        // 판다 이름 바꿈
        //if (newPanda == baby)
        //{
        //    newPanda.name = "Baby" + BabyNumber;
        //    // 판다 위치 저장
        //    PlayerPrefs.SetFloat("BabyX" + BabyNumber, newPanda.transform.position.x);
        //    PlayerPrefs.SetFloat("BabyY" + BabyNumber, newPanda.transform.position.y);
        //    BabyNumber++;
        //}

        newPanda.transform.position = gameObject.transform.position;
        Debug.Log(newPanda.transform.position);
        Destroy(gameObject);
    }

    // 판다의 종류 저장
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
