using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject canvas;
    public GameObject easy;
    public GameObject medium;
    public GameObject hard;


    void Start()
    {
        canvas.SetActive(false);
        
        switch (Variables_Game.instance.difficulty) {
            case "Easy":
                easy.SetActive(true);
                break;
            case "Medium":
                medium.SetActive(true);
                break;
            case "Hard":
                hard.SetActive(true);
                break;
        }
        Invoke("StopTime", 1.0f); 
    }

    public void StopTime(){
        Time.timeScale = 0f; 
    }

    public void Close(){
        canvas.SetActive(true);
        gameObject.SetActive(false);
        Time.timeScale = 1f;
    }


}
