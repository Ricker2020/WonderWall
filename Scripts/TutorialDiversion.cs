using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDiversion : MonoBehaviour
{
    public GameObject easy;
    public GameObject medium;
    public GameObject hard;

    public GameObject canvasGeneral;

    void Start()
    {
        canvasGeneral.SetActive(false);
        /*
        switch (Variables_Diversion.instance.difficulty) {
            case "Easy":
                easy.SetActive(true);
                break;
            case "Medium":
                medium.SetActive(true);
                break;
            case "Hard":
                hard.SetActive(true);
                break;
        }*/
        Invoke("StopTime", 1.0f); 
    }

    public void StopTime(){
        Time.timeScale = 0f; 
    }

    public void Close(){
        canvasGeneral.SetActive(true);
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

}
