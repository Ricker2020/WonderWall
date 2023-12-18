using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step1_movement2 : MonoBehaviour
{
    public GameObject player;
    public GameObject nextStep;


    public float velocidadMostrar = 20f;
    public float cooldown = 5.0f;
    public Text miTexto;
    public string nuevoTexto;

    void Start()
    {
        Variables_Game.instance.status = "Start";
        Variables_Game.instance.movement_tutor = 2;
    }

    void Update()
    {
        if (player.transform.position.x > 3.7 && Variables_Game.instance.status == "Start")
        {
            Variables_Game.instance.status = "Wait";
            StartCoroutine(MostrarTexto());
        }
    }

    IEnumerator MostrarTexto()
    {
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
}
