using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject canvas;
    public Text number;
    int contador=11;
    int aux_contador=10;
    void Start()
    {
        canvas.SetActive(false);
        
        //Invoke("StopTime", 1.0f);
    }

    void Update(){
        if(contador!=aux_contador && contador>0){
            contador--;
            aux_contador=contador;
            Invoke("numberText", 1.0f);
        }
        if(contador==0){
            Variables_Game.instance.status="Start";
            Close();
        }
    }

    void numberText(){
        number.text=contador.ToString();
        aux_contador--;
    }

    
    public void StopTime(){
        Time.timeScale = 0f; 
    }


    public void Close(){
        canvas.SetActive(true);
        gameObject.SetActive(false);
    }


}
