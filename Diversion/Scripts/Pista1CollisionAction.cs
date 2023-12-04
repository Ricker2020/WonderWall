using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pista1CollisionAction : MonoBehaviour
{
    //public Text prueba;
    private void OnTriggerEnter(Collider other){
    // Comprobar si el objeto colisionado tiene la etiqueta
        if (other.gameObject.tag=="PlayerDiversion"){
            Collider thisCollider = GetComponent<Collider>();
            if(thisCollider.gameObject.tag=="CoinPista_1"){
                Variables_Diversion.instance.monedas+=1;
                Variables_Diversion.instance.coin1=false;
            }
            else if(thisCollider.gameObject.tag=="CoinPista_2"){
                Variables_Diversion.instance.monedas+=1;
                Variables_Diversion.instance.coin2=false;
            }
            else if(thisCollider.gameObject.tag=="CoinPista_3"){
                Variables_Diversion.instance.monedas+=1;
                Variables_Diversion.instance.coin3=false;
            }
            else{
                Variables_Diversion.instance.collision=true;
            }

                  
            //prueba.text+=thisCollider.gameObject.tag;
        }
    }
}
