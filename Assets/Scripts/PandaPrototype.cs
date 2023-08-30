using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandaPrototype : MonoBehaviour
{
    public GameObject panda;

    public void AddPanda()
    {
        GameObject newPanda = Instantiate(panda);
        Debug.Log(gameObject.transform.position);
        newPanda.transform.position = gameObject.transform.position;
        Debug.Log("addPanda");
        Debug.Log(newPanda.transform.position);
        Destroy(this);
    }

    public void DeletePanda()
    {
        Destroy(this);
    }
}
