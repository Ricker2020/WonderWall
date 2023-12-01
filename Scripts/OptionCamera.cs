using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionCamera : MonoBehaviour
{
    public void OptionView(int camera)
    {
        // 0 First Person
        // 1 Third Person
        Variables_Game.instance.opcion_camera=camera;
    }
}
