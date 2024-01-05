using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementFly : MonoBehaviour
{
    //public GameObject general_camera;
    //public GameObject playerCameraController2;
    public GameObject general_camera;
    float speedPlayer = 1.2f;
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
            if((transform.position.y <3 && transform.position.y >-3)){
                //ARRIBA
                if(general_camera.transform.rotation.x < 0){
                    transform.position+=transform.up* speedPlayer * Time.deltaTime;
                    Variables_Game.instance.direction_arrow=3;
                }
                //ABAJO
                else{
                    transform.position+=-transform.up* speedPlayer * Time.deltaTime;
                    Variables_Game.instance.direction_arrow=4;
                }

            }else{
                //ABAJO
                if(transform.position.y <= -3) {
                    transform.position = new Vector3(transform.position.x, (float)-3, transform.position.z);
                    //ARRIBA
                    if(general_camera.transform.rotation.x < 0){
                        transform.position+=transform.up* speedPlayer * Time.deltaTime;
                    }
                    
                    Variables_Game.instance.direction_arrow=4;
                    
                //ARRIBA
                } else if(transform.position.y >= 3) {
                    transform.position = new Vector3(transform.position.x, (float)3, transform.position.z);
                    //ABAJO
                    if(general_camera.transform.rotation.x >= 0){
                        transform.position+=-transform.up* speedPlayer * Time.deltaTime;
                    }
                    
                    Variables_Game.instance.direction_arrow=3;
                    
                }
            }
        }
        
        
        if(Variables_Game.instance.status=="End"){
            //POSITION TO THE CENTER
            if(transform.position.y <0 && first){
                left=true;
                first=false;
                
            }
            if(transform.position.y >0 && first){
                left=false;
                first=false;
            }

            if(left){
                if(transform.position.y <0){
                    transform.position+=transform.up* 1.0f * Time.deltaTime; 
                }
            }else{
                if(transform.position.y >0){
                    transform.position+=-transform.up* 1.0f * Time.deltaTime; 
                }
            }
        }
    }
    

}
