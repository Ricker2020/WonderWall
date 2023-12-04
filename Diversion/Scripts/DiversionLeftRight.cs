using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiversionLeftRight : MonoBehaviour
{

    public GameObject general_camera;
    public GameObject arrow;

    void Update()
    {
        float cant=90*Variables_Diversion.instance.player_direction;
        //IZQUIERDA
        if(general_camera.transform.rotation.z < 0){
                arrow.transform.rotation = Quaternion.Euler(0f, 0f, cant);
        }
        //DERECHA
        else{            
                arrow.transform.rotation = Quaternion.Euler(0f, 0f, -cant);          
        }
    }

    public void ChangeDirection(){
        Variables_Diversion.instance.player_direction*=-1;
    }
}
