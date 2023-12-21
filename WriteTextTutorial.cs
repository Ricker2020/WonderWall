using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteTextTutorial : MonoBehaviour
{
public string nuevoTexto;
    public GameObject nextStep;
    public float velocidadMostrar = 20f;
    public float cooldown = 5.0f;
    public Text miTexto;
    public int disableObject=2; /*0:none, 1: disable gameObject, 2: disable text*/

    void Start()
    {
        StartCoroutine(MostrarTexto());
    }

    IEnumerator MostrarTexto()
    {
        miTexto.gameObject.SetActive(true);
        miTexto.text="";
        if(velocidadMostrar!=0){
            for (int i = 0; i < nuevoTexto.Length; i++)
            {
                miTexto.text += nuevoTexto[i];
                yield return new WaitForSeconds(1 / velocidadMostrar);
            }
        }
        else{
            miTexto.text = nuevoTexto;
        }


        
        yield return new WaitForSeconds(cooldown);
        
        if(nextStep){
            nextStep.gameObject.SetActive(true);
        }

        if(disableObject==1){
            gameObject.SetActive(false);
        }
        else if(disableObject==2){
            miTexto.gameObject.SetActive(false);
        }

        
        
    }

}
