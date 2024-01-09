using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTutorial : MonoBehaviour
{

    public GameObject player;
    public GameObject model_owl;
    public GameObject model_duck;
    public GameObject model_capybara;
    public GameObject model_human;
    public GameObject model_robot;
    public GameObject model_proenix;


    //In camera - TrackingSpace
    void Start()
    {

        switch (Variables_Game.instance.player_model)
        {
            case "BÚHO":
                model_owl.SetActive(true);
                break;
            case "PATO":
                model_duck.SetActive(true);
                break;
            case "CAPIBARA":
                model_capybara.SetActive(true);
                break;
            case "HUMANO":
                model_human.SetActive(true);
                break;
            case "ROBOT":
                model_robot.SetActive(true);
                break;
            case "PROENIX":
                model_proenix.SetActive(true);
                break;
        }




    }

    void Update()
    {

        transform.position = new Vector3(0, 3, -6);



    }

}
