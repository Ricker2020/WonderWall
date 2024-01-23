using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMovementTutor : MonoBehaviour
{
    public int movement=0;
    void Start()
    {
        Variables_Game.instance.movement_tutor=movement;
        
    }
}
