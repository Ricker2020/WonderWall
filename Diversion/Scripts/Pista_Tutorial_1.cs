using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pista_Tutorial_1 : MonoBehaviour
{
    public float cooldown = 20.0f;
    
    public GameObject nextStep;

    void Start()
    {
        StartCoroutine(Temporizador());
    }

    IEnumerator Temporizador(){
        yield return new WaitForSeconds(cooldown);
        if (nextStep)
        {
            nextStep.gameObject.SetActive(true);
        }
        gameObject.SetActive(false);

    }
}
