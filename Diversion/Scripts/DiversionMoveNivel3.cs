using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    float speed = 5f;
    int part=1;

    Vector3 pivotPoint= new Vector3(0.0f,0.0f, 0.0f);
    float rotationSpeed = 20f; // Velocidad de rotación en grados por segundo
    
    //PISTA - DECENSO
    float velocidadY = 0.4f;
    float velocidadZ = 1.1f; // Velocidad de movimiento

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

        if(transform.position.z>-172 && part==3 && Variables_Diversion.instance.status=="Start"){
            transform.Translate(-1.0f*Vector3.forward *speed * Time.deltaTime, Space.Self);
            if(transform.position.z<-172){
                part=4;
                Vector3 newPosition = transform.position;
                newPosition.z = -172f;
                transform.position = newPosition;
            }
        }

        if(transform.position.z>-237 && part==4){
            transform.Translate(-Vector3.up * velocidadY * Time.deltaTime);
            transform.Translate(-Vector3.forward * velocidadZ * Time.deltaTime);
                if(transform.position.z<-237){
                    part=5;
                    Vector3 newPosition = transform.position;
                    newPosition.z = -237f;
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
