using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public GameObject general_camera;
    //public GameObject playerCameraController2;
    public GameObject general_camera;
    float speedPlayer = 1.0f;
    bool left=true;
    bool first=true;

    void Start()
    {
        Variables_Game.instance.player=gameObject; //En DoorAction este objeto suma puntos
        //DIFFICULTY
        /*switch (Variables_Game.instance.difficulty) {
            case "facil":
                speedPlayer=1.2f;
                break;
            case "medio":
                speedPlayer=1.7f;
                break;
            case "dificil":
                speedPlayer=1.8f;
                break;
        }*/

        switch (Variables_Game.instance.increment_speed) {
            case "x1.00":
                speedPlayer=speedPlayer*1.0f;
                break;
            case "x1.25":
                speedPlayer=speedPlayer*1.2f;
                break;
            case "x1.50":
                speedPlayer=speedPlayer*1.3f;
                break;
            case "x1.75":
                speedPlayer=speedPlayer*1.4f;
                break;
            case "x2.00":
                speedPlayer=speedPlayer*1.5f;
                break;
        }
        
    }

    
    void Update()
    {
        //if(!Variables_Game.instance.endGame){
        if(Variables_Game.instance.status=="Start"){
            //DENTRO DEL RANGO PLANE
            if((transform.position.x <4 && transform.position.x >-4)){
                //DERECHA
                if(general_camera.transform.rotation.z < 0){
                    transform.position+=-transform.right* speedPlayer * Time.deltaTime*Variables_Game.instance.player_direction;
                    Variables_Game.instance.direction_arrow=2;
                }
                //IZQUIERDA
                else{
                    transform.position+=transform.right* speedPlayer * Time.deltaTime*Variables_Game.instance.player_direction;
                    Variables_Game.instance.direction_arrow=1;
                }

            }else{
                //IZQUIERDA
                if(transform.position.x <= -4) {
                    transform.position = new Vector3((float)-4, transform.position.y, transform.position.z);
                    
                    if(general_camera.transform.rotation.z < 0 && Variables_Game.instance.player_direction==-1 ){
                        transform.position+=-transform.right* speedPlayer * Time.deltaTime*-1;
                    }
                    if(general_camera.transform.rotation.z > 0 && Variables_Game.instance.player_direction==1 ){
                        transform.position+=transform.right* speedPlayer * Time.deltaTime;
                    }
                    Variables_Game.instance.direction_arrow=1;
                    
                //DERECHA
                } else if(transform.position.x >= 4) {
                    transform.position = new Vector3((float)4, transform.position.y, transform.position.z);
                    
                    if(general_camera.transform.rotation.z > 0 && Variables_Game.instance.player_direction==-1){
                        transform.position+=transform.right* speedPlayer * Time.deltaTime*-1;
                    }
                    if(general_camera.transform.rotation.z < 0 && Variables_Game.instance.player_direction==1 ){
                        transform.position+=-transform.right* speedPlayer * Time.deltaTime;
                    }
                    Variables_Game.instance.direction_arrow=2;
                    
                }
            }
        }
        
        
        if(Variables_Game.instance.status=="End"){
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
