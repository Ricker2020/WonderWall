using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pista3CollitionAction : MonoBehaviour
{
    // Start is called before the first frame update
    

     private void OnTriggerEnter(Collider other){
    // Comprobar si el objeto colisionado tiene la etiqueta
        if (other.gameObject.tag=="PlayerDiversion"){
            Collider thisCollider = GetComponent<Collider>();
            if(thisCollider.gameObject.tag=="CoinPista3_1"){
                Variables_Diversion.instance.monedas+=1;
                Variables_Diversion.instance.coin1=false;
            }
            else if(thisCollider.gameObject.tag=="CoinPista3_2"){
                Variables_Diversion.instance.monedas+=1;
                Variables_Diversion.instance.coin2=false;
            }
            else if(thisCollider.gameObject.tag=="CoinPista3_3"){
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