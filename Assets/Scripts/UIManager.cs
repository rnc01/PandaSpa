using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject baby_panda_prototype;
    public void AddBabyPanda()
    {
        GameObject newBabyPanda = Instantiate(baby_panda_prototype);
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        newPosition.z = -1;
        newBabyPanda.transform.position = newPosition;
    }
}
