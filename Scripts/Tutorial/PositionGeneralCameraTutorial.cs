using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGeneralCameraTutorial : MonoBehaviour
{

    public GameObject player;
    public GameObject model_owl;
    public GameObject model_duck;
    public GameObject model_capybara;
    public GameObject model_human;
    public GameObject model_robot;
    public GameObject model_proenix;

    public bool normal_mode = true;
    //In camera - TrackingSpace
    void Start()
    {
        if (Variables_Game.instance.opcion_camera == 0)
        {
            //First Person
            model_owl.SetActive(false);
            model_duck.SetActive(false);
            model_capybara.SetActive(false);
            model_human.SetActive(false);
            model_robot.SetActive(false);
            model_proenix.SetActive(false);
        }
        else
        {
            model_owl.SetActive(true);
        }


    }

    void Update()
    {
        if (normal_mode) //terrestre
        {
            if (Variables_Game.instance.opcion_camera == 0)
            {
                //Change the position of the camera to that of the model - First Person
                transform.position = new Vector3(player.transform.position.x, (float)0.8, player.transform.position.z);

            }
            else
            {
                //Third Person
                transform.position = new Vector3(0, 3, -6);
            }
        }
        else //volador
        {
            if (Variables_Game.instance.opcion_camera == 0)
            {
                //Change the position of the camera to that of the model - First Person
                transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);

            }
            else
            {
                //Third Person
                transform.position = new Vector3(0, 0, -6);
            }
        }



    }
}
