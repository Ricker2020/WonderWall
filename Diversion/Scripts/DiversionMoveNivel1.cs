using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiversionMoveNivel1 : MonoBehaviour
{
    float speed = 5f;
    int part=1;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.z>-133 && part==1 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(-1.0f*Vector3.forward *speed * Time.deltaTime, Space.Self);
            if(transform.position.z<-133){
                part=2;
                Vector3 newPosition = transform.position;
                newPosition.z = -133;
                transform.position = newPosition;
            }
        }

        if(Variables_Diversion.instance.collision){
            Vector3 newPosition = transform.position;
            newPosition.x = 0;
            newPosition.y = 0;
            newPosition.z = 20;
            transform.position = newPosition;
            Variables_Diversion.instance.collision=false;
            Variables_Diversion.instance.status="Wait";
            Invoke("cooldown_activate", 5.0f);
        }

    }


    void cooldown_activate(){
        Variables_Diversion.instance.status="Start";
    }




}
