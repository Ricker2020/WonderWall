using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTutorDefine : MonoBehaviour
{
    public int movement=0;
    void Start()
    {
        Variables_Diversion.instance.movement_tutor=movement;
        
    }


}
