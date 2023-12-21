using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionActionTutorial : MonoBehaviour
{
    public int result=1; /* 1:No Collision, 2:collision, 3:Coin*/
    public Text textResult;
  
    private void OnTriggerEnter(Collider other){
    // Comprobar si el objeto colisionado tiene la etiqueta
        if (other.gameObject.tag=="PlayerDiversion"){
             result=2;   
            Collider thisCollider = GetComponent<Collider>();
            if(thisCollider.gameObject.tag=="CoinPista_1"){
                result=3;   
            }
            else if(thisCollider.gameObject.tag=="CoinPista_2"){
                result=3;   
            }
            else if(thisCollider.gameObject.tag=="CoinPista_3"){
                result=3;   
            }


            if(result==2){
                textResult.text="!!!CHOCASTE¡¡¡";
            }else if(result==3){
                textResult.text="!!!GENIAL¡¡¡ RECOGISTE UNA MONEDA";
            }
        }
    }
}
