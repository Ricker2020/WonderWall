using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCollitionAction : MonoBehaviour
{
    
    //public Text prueba;
    private void OnTriggerEnter(Collider other){
    // Comprobar si el objeto colisionado tiene la etiqueta
        if (other.gameObject.tag=="PlayerDiversion"){
            Collider thisCollider = GetComponent<Collider>();
            if(thisCollider.gameObject.tag=="CoinDiversion"){
                Variables_Diversion.instance.puntaje+=150;
                Destroy (gameObject);
                //Variables_Diversion.instance.CoinMusic();

            }
            else{
                if (Variables_Diversion.instance.eliminar_vidas)
                {
                    if (Variables_Diversion.instance.vidas_carrera > 1)
                    {
                        Variables_Diversion.instance.vidas_carrera -= 1;
                        //Esperar un segundo
                    }
                    else if (Variables_Diversion.instance.vidas_carrera == 1)
                    {
                        Variables_Diversion.instance.vidas_carrera -= 1;
                        Variables_Diversion.instance.status = "End";
                    }
                }
            }       
            //prueba.text+=thisCollider.gameObject.tag;
        }
    }

}
