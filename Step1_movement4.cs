using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step1_movement4 : MonoBehaviour
{
    public GameObject player;
    public GameObject nextStep;

    void Start()
    {
        Variables_Game.instance.status="Start";
        Variables_Game.instance.movement_tutor=4;
    }

    void Update(){
        if(player.transform.position.y<0.05){
            Variables_Game.instance.status="Wait";
            if(nextStep){
                nextStep.gameObject.SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
}
