using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGeneralCanvas : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        if(Variables_Game.instance.opcion_camera==0){
            transform.position=new Vector3(player.transform.position.x,transform.position.y,(float)5.6);
        }
        
    }
}
