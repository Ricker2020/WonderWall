using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGeneralCanvasDiversion : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        if(Variables_Diversion.instance.opcion_camera==0){
            transform.position=new Vector3(player.transform.position.x,transform.position.y,(float)5.6);
        }
        
    }
}
