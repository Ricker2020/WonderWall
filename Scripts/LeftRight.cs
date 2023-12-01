using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{

    public GameObject general_camera;
    public GameObject arrow;



    void Update()
    {
        //IZQUIERDA
        /*float cant=90*Variables_Game.instance.player_direction;

        if(general_camera.transform.rotation.z < 0){
            if(!rotate_left && !rotate_right){ //First time
                rotate_left=true;
                rotate_right=false;
                arrow.transform.Rotate(0f, 0f, cant );
            }

            if(!rotate_left && rotate_right){
                rotate_left=true;
                rotate_right=false;
                arrow.transform.Rotate(0f, 0f, cant*2);
            }
                 
        }
        //DERECHA
        else{            
            if(!rotate_left && !rotate_right){ //First time
                rotate_left=false;
                rotate_right=true;
                arrow.transform.Rotate(0f, 0f, -cant);
            }

            if(rotate_left && !rotate_right){
                rotate_left=false;
                rotate_right=true;
                arrow.transform.Rotate(0f, 0f, -cant*2);
            }             
        }*/

        
        float cant=90*Variables_Game.instance.player_direction;
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
        Variables_Game.instance.player_direction*=-1;
        /*if(rotate_left){
            arrow.transform.Rotate(0f, 0f, 90 );
        }
        if(rotate_right){
            arrow.transform.Rotate(0f, 0f, -90 );
        }
        rotate_left=false;
        rotate_right=false;*/
    }
}
