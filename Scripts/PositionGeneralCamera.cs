using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGeneralCamera : MonoBehaviour
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
        if(Variables_Game.instance.opcion_camera==0){
            //First Person
            model_owl.SetActive(false);
            model_duck.SetActive(false);
            model_capybara.SetActive(false);
            model_human.SetActive(false);
            model_robot.SetActive(false);
            model_proenix.SetActive(false);
        }
        else{
            //Third Person
            switch(Variables_Game.instance.player_model) {
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
       
        
    }

    void Update()
    {
        if(Variables_Game.instance.opcion_camera==0){
            //Change the position of the camera to that of the model - First Person
            transform.position=new Vector3(player.transform.position.x,(float)0.8,player.transform.position.z);

        }else{
            //Third Person
            transform.position=new Vector3(0,3,-6);
        }
        
        
    }
}
