using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCameraTutorialDiversion : MonoBehaviour
{
    public GameObject canvas;
    public GameObject tutor;
    void Start()
    {
        if (Variables_Diversion.instance.opcion_camera == 0)
        {
            canvas.transform.position=new Vector3(canvas.transform.position.x, canvas.transform.position.y, canvas.transform.position.z+4f);
            tutor.transform.position=new Vector3(tutor.transform.position.x, tutor.transform.position.y, tutor.transform.position.z+4f);
        }

    }


}
