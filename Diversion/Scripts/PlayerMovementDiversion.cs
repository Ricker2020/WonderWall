using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementDiversion : MonoBehaviour
{
    //public GameObject general_camera;
    //public GameObject playerCameraController2;
    public GameObject general_camera;
    public float speedPlayer = 1.2f;
    bool left=true;
    bool first=true;

    void Start()
    {
        Variables_Diversion.instance.player=gameObject; //En DoorAction este objeto suma puntos
        
        
    }

    
    void Update()
    {
        //if(!Variables_Diversion.instance.endGame){
        if(Variables_Diversion.instance.status=="Start"){
            //DENTRO DEL RANGO PLANE
            if((transform.position.x <4 && transform.position.x >-4)){
                //DERECHA
                if(general_camera.transform.rotation.z < 0){
                    transform.position+=-transform.right* speedPlayer * Time.deltaTime*Variables_Diversion.instance.player_direction;
                }
                //IZQUIERDA
                else{
                    transform.position+=transform.right* speedPlayer * Time.deltaTime*Variables_Diversion.instance.player_direction;
                }

            }else{
                //IZQUIERDA
                if(transform.position.x <= -4) {
                    transform.position = new Vector3((float)-4, transform.position.y, transform.position.z);
                    
                    if(general_camera.transform.rotation.z < 0 && Variables_Diversion.instance.player_direction==-1 ){
                        transform.position+=-transform.right* speedPlayer * Time.deltaTime*-1;
                    }
                    if(general_camera.transform.rotation.z > 0 && Variables_Diversion.instance.player_direction==1 ){
                        transform.position+=transform.right* speedPlayer * Time.deltaTime;
                    }
                    
                //DERECHA
                } else if(transform.position.x >= 4) {
                    transform.position = new Vector3((float)4, transform.position.y, transform.position.z);
                    
                    if(general_camera.transform.rotation.z > 0 && Variables_Diversion.instance.player_direction==-1){
                        transform.position+=transform.right* speedPlayer * Time.deltaTime*-1;
                    }
                    if(general_camera.transform.rotation.z < 0 && Variables_Diversion.instance.player_direction==1 ){
                        transform.position+=-transform.right* speedPlayer * Time.deltaTime;
                    }
                    
                }
            }
        }
        
        
        if(Variables_Diversion.instance.status=="End"){
            //POSITION TO THE CENTER
            if(transform.position.x <0 && first){
                left=true;
                first=false;
                
            }
            if(transform.position.x >0 && first){
                left=false;
                first=false;
            }

            if(left){
                if(transform.position.x <0){
                    transform.position+=transform.right* 1.0f * Time.deltaTime; 
                }
            }else{
                if(transform.position.x >0){
                    transform.position+=-transform.right* 1.0f * Time.deltaTime; 
                }
            }
        }
    }
    

}
