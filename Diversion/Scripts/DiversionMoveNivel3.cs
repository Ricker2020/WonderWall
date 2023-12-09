using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiversionMoveNivel3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
/*
    public float velocidadY = 0.8f;
    public float velocidadZ = 1f; // Velocidad de movimiento
    public float anguloY = 15f; // Ángulo en grados
    public float anguloZ = 15f;

    private void Update()
    {
        // Calcula la dirección en el eje Y basada en el ángulo
        Vector3 direccionY = Quaternion.Euler(0f, anguloY, 0f) * Vector3.up ;
        Vector3 direccionZ = Quaternion.Euler(0f, 0f, anguloZ) * Vector3.forward;

        // Mueve el objeto en la dirección calculada
        transform.Translate(direccionY * velocidadY * Time.deltaTime);
        transform.Translate(-direccionZ * velocidadZ * Time.deltaTime);
    }*/

    //PISTA
    float speed = 8f;
    int part=1;

    Vector3 pivotPoint= new Vector3(0.0f,0.0f, 0.0f);
    float rotationSpeed = 20f; // Velocidad de rotación en grados por segundo
    
    //PISTA - DECENSO
    float velocidadY = 1.6f;
    float velocidadZ = 4.4f;// Velocidad de movimiento
    public Text answer;
    public GameObject general_camera;
    public GameObject elevator;



    private void Update()
    {
        //PRIMERA PARTE
        if(transform.position.z>-49 && part==1 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(-1.0f*Vector3.forward *speed * Time.deltaTime, Space.Self);
            if(transform.position.z<-49){
                part=2;
                Vector3 newPosition = transform.position;
                newPosition.z = -49f;
                transform.position = newPosition;
            }
        }

        // Mueve el objeto en la dirección calculada
        /*transform.Translate(Vector3.up * velocidadY * Time.deltaTime);
        transform.Translate(-Vector3.forward * velocidadZ * Time.deltaTime);*/

        if(transform.position.z>-112 && part==2 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(Vector3.up * velocidadY * Time.deltaTime);
            transform.Translate(-Vector3.forward * velocidadZ * Time.deltaTime);
                if(transform.position.z<-112){
                    part=3;
                    Vector3 newPosition = transform.position;
                    newPosition.z = -112f;
                    transform.position = newPosition;
                }
        }

        if(transform.position.z>-177 && part==3 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(-1.0f*Vector3.forward *speed * Time.deltaTime, Space.Self);
            if(transform.position.z<-177){
                part=4;
                Vector3 newPosition = transform.position;
                newPosition.z = -177f;
                transform.position = newPosition;
            }
        }

        //ELEVADOR
        if(transform.position.z==-177 && part==4){
            //ARRIBA
            if(general_camera.transform.rotation.x < 0){
                transform.Translate(-Vector3.up * speed * Time.deltaTime);
                elevator.transform.Translate(Vector3.up * speed * Time.deltaTime);

                if(transform.position.y<6){
                    part=5;
                    Vector3 newPosition = transform.position;
                    newPosition.y=6f;
                    transform.position = newPosition;
                }
            }
        }

        if(transform.position.z>-257 && part==5 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(-1.0f*Vector3.forward *speed * Time.deltaTime, Space.Self);
            if(transform.position.z<-257){
                part=6;
                Vector3 newPosition = transform.position;
                newPosition.z = -257f;
                transform.position = newPosition;
            }
        }

        if(part==6 && Variables_Diversion.instance.status=="Start"){
            // Calcula el ángulo de rotación basado en el ángulo fijo y la velocidad de rotación
            float angleToRotate =  rotationSpeed*Time.deltaTime;
            // Rota el objeto alrededor del punto de pivote en el eje Y
            transform.RotateAround(pivotPoint, -Vector3.up, angleToRotate);
            Vector3 rotationEulerAngles = transform.rotation.eulerAngles;
            answer.text=":"+rotationEulerAngles.x+":"+rotationEulerAngles.y+":"+rotationEulerAngles.z;

            if(rotationEulerAngles.y<270.0f ){
                part=7;
                Vector3 newRotation = new Vector3(rotationEulerAngles.x, 270.0f, rotationEulerAngles.z);
                transform.rotation = Quaternion.Euler(newRotation);
            }
        }

        if(part==7 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(1.0f*Vector3.left *speed * Time.deltaTime, Space.Self);

            if(transform.position.z<-52.5){
                part=8;
                Vector3 newPosition = transform.position;
                newPosition.z = -52.5f;
                transform.position = newPosition;
            }
        }



        if(part==8 && Variables_Diversion.instance.status=="Start"){
            // Calcula el ángulo de rotación basado en el ángulo fijo y la velocidad de rotación
            float angleToRotate =  rotationSpeed*Time.deltaTime;
            // Rota el objeto alrededor del punto de pivote en el eje Y
            transform.RotateAround(pivotPoint, Vector3.up, angleToRotate);
            Vector3 rotationEulerAngles = transform.rotation.eulerAngles;
            answer.text=":"+rotationEulerAngles.x+":"+rotationEulerAngles.y+":"+rotationEulerAngles.z;

            if(rotationEulerAngles.y>359.5f ){
                part=9;
                Vector3 newRotation = new Vector3(rotationEulerAngles.x, 359.5f, rotationEulerAngles.z);
                transform.rotation = Quaternion.Euler(newRotation);
            }
        }


        if(transform.position.z>-313 && part==9 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(-1.0f*Vector3.forward *speed * Time.deltaTime, Space.Self);
            if(transform.position.z<-313){
                part=10;
                Vector3 newPosition = transform.position;
                newPosition.z = -313f;
                transform.position = newPosition;
            }
        }

        if(Variables_Diversion.instance.collision){
            Vector3 newPosition = transform.position;
            newPosition.x = 0;
            newPosition.y = 0;
            newPosition.z = 0;
            transform.position = newPosition;

            Vector3 newRotation = new Vector3(0.0f, 0.0f, 0.0f);
            transform.rotation = Quaternion.Euler(newRotation);

            part=1;

            Variables_Diversion.instance.collision=false;
            Variables_Diversion.instance.status="Wait";
            Invoke("cooldown_activate", 5.0f);
        }       

        
    }  
        void cooldown_activate(){
            Variables_Diversion.instance.status="Start";
        }

}
