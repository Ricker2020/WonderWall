using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiversionMoveNivel2 : MonoBehaviour
{


    float speed = 5f;
    int part=1;

    Vector3 pivotPoint= new Vector3(0.0f,0.0f, 0.0f);
    float rotationSpeed = 20f; // Velocidad de rotación en grados por segundo

    

    //public Text answer;
    void Update()
    {
        
        if(transform.position.z>-21.5 && part==1 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(-1.0f*Vector3.forward *speed * Time.deltaTime, Space.Self);
            if(transform.position.z<-21.5){
                part=2;
                Vector3 newPosition = transform.position;
                newPosition.z = -21.5f;
                transform.position = newPosition;
            }
        }

        if(part==2 && Variables_Diversion.instance.status=="Start"){
            // Calcula el ángulo de rotación basado en el ángulo fijo y la velocidad de rotación
            float angleToRotate =  rotationSpeed*Time.deltaTime;
            // Rota el objeto alrededor del punto de pivote en el eje Y
            transform.RotateAround(pivotPoint,  Vector3.up, angleToRotate);
            Vector3 rotationEulerAngles = transform.rotation.eulerAngles;
            //answer.text=":"+rotationEulerAngles.x+":"+rotationEulerAngles.y+":"+rotationEulerAngles.z;
            
            if(rotationEulerAngles.y>90.0f ){
                part=3;
                Vector3 newRotation = new Vector3(rotationEulerAngles.x, 90.0f, rotationEulerAngles.z);
                transform.rotation = Quaternion.Euler(newRotation);
            }
        }

        if(part==3 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(Vector3.right *speed * Time.deltaTime, Space.Self);
            if(transform.position.z<-49.5){
                part=4;
                Vector3 newPosition = transform.position;
                newPosition.z = -49.5f;
                transform.position = newPosition;
            }
        }

        if(part==4 && Variables_Diversion.instance.status=="Start"){
            // Calcula el ángulo de rotación basado en el ángulo fijo y la velocidad de rotación
            float angleToRotate =  rotationSpeed*Time.deltaTime;
            // Rota el objeto alrededor del punto de pivote en el eje Y
            transform.RotateAround(pivotPoint, -Vector3.up, angleToRotate);
            Vector3 rotationEulerAngles = transform.rotation.eulerAngles;
            //answer.text=":"+rotationEulerAngles.x+":"+rotationEulerAngles.y+":"+rotationEulerAngles.z;
            
            if(rotationEulerAngles.y>300.0f ){
                part=5;
                Vector3 newRotation = new Vector3(rotationEulerAngles.x, 0.0f, rotationEulerAngles.z);
                transform.rotation = Quaternion.Euler(newRotation);
            }
        }

        if(part==5 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(-Vector3.forward *speed * Time.deltaTime, Space.Self);
            if(transform.position.z<-65){
                part=6;
                Vector3 newPosition = transform.position;
                newPosition.z = -65.0f;
                transform.position = newPosition;
            }
        }

        if(transform.position.z>=-65 && part==6 && Variables_Diversion.instance.status=="Start"){
            Variables_Diversion.instance.status="End";
        }
        
        if(Variables_Diversion.instance.collision){
            Vector3 newPosition = transform.position;
            newPosition.x = 0;
            newPosition.y = 0;
            newPosition.z = 18;
            transform.position = newPosition;

            Vector3 newRotation = new Vector3(0.0f, 0.0f, 0.0f);
            transform.rotation = Quaternion.Euler(newRotation);

            part=1;

            Variables_Diversion.instance.collision=false;
            Variables_Diversion.instance.attempts+=1; //Attempts
            Variables_Diversion.instance.status="Wait";
            Invoke("cooldown_activate", 5.0f);
        }       
    }

    void cooldown_activate(){
        Variables_Diversion.instance.status="Start";
    }
}
