using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstallCheck : MonoBehaviour
{
    bool isInSpa = false;
    bool isPandaCollided = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Spa")
            isInSpa = true;
        if (collision.tag == "Panda")
            isPandaCollided = true;
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
        //if (caninstall())
        //    gameobject.getcomponent<spriterenderer>().color = color.red;
        //else
        //    gameobject.getcomponent<spriterenderer>().color = color.white;
    }
}
