using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiversionOptionCamera : MonoBehaviour
{
    public void OptionView(int camera)
    {
        // 0 First Person
        // 1 Third Person
        Variables_Diversion.instance.opcion_camera=camera;
    }
}
