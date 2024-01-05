using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeMovementPlayer : MonoBehaviour
{
    public GameObject player;
    public bool left_right = false;
    public bool up_down = false;
    void Start()
    {
        PlayerMovement playerScript = player.GetComponent<PlayerMovement>();
        PlayerMovementFly playerScriptFly = player.GetComponent<PlayerMovementFly>();
        playerScript.enabled = left_right;
        playerScriptFly.enabled = up_down;

    }


}