using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contadorVidas : MonoBehaviour
{
    int vidas_current;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;

    void Start()
    {
        vidas_current=3;
    }


    void Update()
    {
        if(Variables_Diversion.instance.vidas_carrera!=vidas_current){
            vidas_current=Variables_Diversion.instance.vidas_carrera;
            if(vidas_current==2){
                vida1.SetActive(false);
            }
            if(vidas_current==1){
                vida1.SetActive(false);
                vida2.SetActive(false);
            }
            if(vidas_current==0){
                vida1.SetActive(false);
                vida2.SetActive(false);
                vida3.SetActive(false);
            }
            Variables_Diversion.instance.eliminar_vidas = false;
            Invoke("cooldown_activate", 1.0f);


        }

        
    }

    void cooldown_activate(){
        Variables_Diversion.instance.eliminar_vidas = true;
    }


}
