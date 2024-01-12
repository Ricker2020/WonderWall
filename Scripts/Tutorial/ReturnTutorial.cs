using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTutorial : MonoBehaviour
{
    public GameObject view_current;
    public GameObject view_first;
    public GameObject view_third;
    public void ButtonReturn()
    {
        if (Variables_Game.instance.opcion_camera == 1)
        { //3er view
            view_current.SetActive(false);
            view_third.SetActive(true);
        }
        else
        {
            view_current.SetActive(false);
            view_first.SetActive(true);
        }

    }
}
