using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteText : MonoBehaviour
{
    public string nuevoTexto;
    public GameObject nextStep;

    public float velocidadMostrar = 20f;
    public float cooldown = 5.0f;


    public Text miTexto;
    public bool disableObject=false;

    void Start()
    {
        StartCoroutine(MostrarTexto());
    }

    IEnumerator MostrarTexto()
    {
        miTexto.gameObject.SetActive(true);
        miTexto.text="";
        for (int i = 0; i < nuevoTexto.Length; i++)
        {
            miTexto.text += nuevoTexto[i];
            yield return new WaitForSeconds(1 / velocidadMostrar);
        }
        /*nextStep.gameObject.SetActive(true);
        gameObject.SetActive(false);*/
        
        yield return new WaitForSeconds(cooldown);
        
        if(nextStep){
            nextStep.gameObject.SetActive(true);
        }
        if(disableObject){
            gameObject.SetActive(false);
        }
        else{
            miTexto.gameObject.SetActive(false);

        }
        
        
    }

  
}
