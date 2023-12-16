using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step1_movement3 : MonoBehaviour
{
    public GameObject player;
    public GameObject nextStep;

    void Start()
    {
        PlayerMovement playerScript = player.GetComponent<PlayerMovement>();
        PlayerMovementFly playerScriptFly = player.GetComponent<PlayerMovementFly>();
        playerScript.enabled = false;
        playerScriptFly.enabled = true;


        Variables_Game.instance.status="Start";
        Variables_Game.instance.movement_tutor=3;
    }

    void Update(){
        if(player.transform.position.y>2.90){
            Variables_Game.instance.status="Wait";
            if(nextStep){
                nextStep.gameObject.SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }
}
