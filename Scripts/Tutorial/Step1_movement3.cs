using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step1_movement3 : MonoBehaviour
{
    public GameObject player;
    public GameObject nextStep;

    public float velocidadMostrar = 20f;
    public float cooldown = 5.0f;
    public Text miTexto;
    public string textoInicial;

    public string nuevoTexto;
    public GameObject camara;


    void Start()
    {
        PlayerMovement playerScript = player.GetComponent<PlayerMovement>();
        PlayerMovementFly playerScriptFly = player.GetComponent<PlayerMovementFly>();
        playerScript.enabled = false;
        playerScriptFly.enabled = true;

        PositionGeneralCameraTutorial camaraScript = camara.GetComponent<PositionGeneralCameraTutorial>();
        camaraScript.normal_mode=false;




        StartCoroutine(Texto());
        Variables_Game.instance.movement_tutor = 3;
    }

    void Update()
    {
        if (player.transform.position.y > 2.90 && Variables_Game.instance.status == "Start")
        {
            Variables_Game.instance.status = "Wait";
            StartCoroutine(MostrarTexto());
        }
    }

    IEnumerator MostrarTexto()
    {
        miTexto.text="";
        for (int i = 0; i < nuevoTexto.Length; i++)
        {
            miTexto.text += nuevoTexto[i];
            yield return new WaitForSeconds(1 / velocidadMostrar);
        }
        yield return new WaitForSeconds(cooldown);
        if (nextStep)
        {
            nextStep.gameObject.SetActive(true);
        }
        gameObject.SetActive(false);
    }

            IEnumerator Texto()
    {
        miTexto.text="";
        for (int i = 0; i < textoInicial.Length; i++)
        {
            miTexto.text += textoInicial[i];
            yield return new WaitForSeconds(1 / velocidadMostrar);
        }
        
        Variables_Game.instance.status = "Start";
        
    }
}
