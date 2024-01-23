using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGeneralCanvasFly : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        if(Variables_Game.instance.opcion_camera==0){
            transform.position=new Vector3(transform.position.x, player.transform.position.y,(float)5.6);
        }
        
    }
}
