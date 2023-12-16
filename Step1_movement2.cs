using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step1_movement2 : MonoBehaviour
{
    public GameObject player;
    public GameObject nextStep;

    void Start()
    {
        Variables_Game.instance.status="Start";
        Variables_Game.instance.movement_tutor=2;
    }

    void Update(){
        if(player.transform.position.x>3.7){
            Variables_Game.instance.status="Wait";
            if(nextStep){
                nextStep.gameObject.SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
}
