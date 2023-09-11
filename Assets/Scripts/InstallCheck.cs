using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstallCheck : MonoBehaviour
{
    public bool isInSpa = false;
    public bool isPandaCollided = false;
    public RawImage pandaImage; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Spa")
            isInSpa = true;
        if (collision.tag == "Panda")
            isPandaCollided = true;


        Debug.Log(CanInstall());
        if (CanInstall())
        {
            pandaImage.color = new Color32(255, 255, 255, 255);
        }
        else
        {
            pandaImage.color = new Color32(255, 64, 64, 128);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Spa")
            isInSpa = false;
        if (collision.tag == "Panda")
            isPandaCollided = false;

        if (CanInstall())
        {
            pandaImage.color = new Color32(255, 255, 255, 255);
        }
        else
        {
            pandaImage.color = new Color32(255, 64, 64, 128);
        }
    }

    public bool CanInstall()
    {
        if (isInSpa == true && isPandaCollided == false)
            return true;
        else
            return false;
    }

    private void Update()
    {

    }
}
