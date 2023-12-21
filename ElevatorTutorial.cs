using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTutorial : MonoBehaviour
{
    public GameObject general_camera;
    float speed = 1.0f;
    public GameObject object1;
    public GameObject object2;
    public GameObject nextStep;
    bool stop=false;
    public bool up_player=true;


    void Start()
    {
        
    }

    
    void Update()
    {
        //ARRIBA
        if(up_player && !stop){
            if(general_camera.transform.rotation.x < 0 ){
                
                //transform.Translate(-Vector3.up * speed * Time.deltaTime);
                object1.transform.Translate(-Vector3.up * speed * Time.deltaTime);
                object2.transform.Translate(-Vector3.up * speed * Time.deltaTime);

                if(object1.transform.position.y < -6){
                    stop=true;
                    if(nextStep){
                        nextStep.gameObject.SetActive(true);
                    }
                    gameObject.SetActive(false);
                }
            }
        }
        else if(!up_player && !stop){
            //ABAJO
            if(general_camera.transform.rotation.x > 0 && !stop){
                //transform.Translate(-Vector3.up * speed * Time.deltaTime);
                object1.transform.Translate(Vector3.up * speed * Time.deltaTime);
                object2.transform.Translate(Vector3.up * speed * Time.deltaTime);

                if(object1.transform.position.y > 0){
                    stop=true;
                    if(nextStep){
                        nextStep.gameObject.SetActive(true);
                    }
                    gameObject.SetActive(false);
                }
            }
        }

        
    }
}
