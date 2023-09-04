using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandaPrototype : MonoBehaviour
{
    public GameObject panda;
    public GameObject baby;
    static int BabyNumber = 1;


    public int PandaNumberGet()
    {
        return BabyNumber;
    }

    public void AddPanda()
    {
        if (gameObject.transform.Find("Panda").gameObject.GetComponent<InstallCheck>().CanInstall() == false) return;
        GameObject newPanda = Instantiate(panda);

        // 판다 이름 바꿈
        if (newPanda == baby)
        {
            newPanda.name = "Baby" + BabyNumber;
            // 판다 위치 저장
            PlayerPrefs.SetFloat("BabyX" + BabyNumber, newPanda.transform.position.x);
            PlayerPrefs.SetFloat("BabyY" + BabyNumber, newPanda.transform.position.y);
            BabyNumber++;
        }
        Debug.Log(gameObject.transform.position);
        newPanda.transform.position = gameObject.transform.position;
        Debug.Log("addPanda");
        Debug.Log(newPanda.transform.position);

        Destroy(gameObject);
    }

    public void AddPanda(float x, float y, GameObject panda)
    {
        GameObject newPanda = Instantiate(panda);

        newPanda.transform.position = new Vector3(x, y, 0);
    }

    public void DeletePanda()
    {
        Destroy(gameObject);
    }
}
