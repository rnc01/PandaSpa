using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SellerPanda : MonoBehaviour
{
    public int level = 1;
    public GameObject[] food = new GameObject[3];
    public bool canCook = true;
    public int coolTime = 3;
    public int time = 3;
    public bool onFood = false;
    public Transform tf;
    // public int[] cost = new int[3] { 500, 1000, 2000 };
    public TextMeshProUGUI txt;

    public void LevelUp()
    {
        level += 1;
    }

    void Update()
    {
        txt.text = "(LV:" + level + ")";
        if (canCook == true && onFood == false)
        {
            StartCoroutine(Cook());
        }
    }

    IEnumerator Cook()
    {
        canCook = false;
        int time = coolTime;
        while(time > 0) {
            yield return new WaitForSeconds(1f);
            time -= 1;
        }
        Instantiate(food[level - 1], tf);
        canCook = true;
        onFood = true;
        yield break; 
    }

    
}
