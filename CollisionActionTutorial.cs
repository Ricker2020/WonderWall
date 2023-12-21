using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionActionTutorial : MonoBehaviour
{
    public int result=1; /* 1:No Collision, 2:collision, 3:Coin*/
    public Text textResult;
    public GameObject vida;
  
    private void OnTriggerEnter(Collider other){
    // Comprobar si el objeto colisionado tiene la etiqueta
        if (other.gameObject.tag=="PlayerDiversion"){
             result=2;   
            Collider thisCollider = GetComponent<Collider>();
            if(thisCollider.gameObject.tag=="CoinDiversion"){
                result=3;   
            }


            if(result==2){
                textResult.text="!!!CHOCASTE¡¡¡";
                if(vida){
                    vida.gameObject.SetActive(false);
                }
                

            }else if(result==3){
                textResult.text="!!!GENIAL¡¡¡ RECOGISTE UNA MONEDA";
            }
        }
    }
}
