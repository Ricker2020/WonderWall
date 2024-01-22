using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetValuesDiversion : MonoBehaviour
{

    void Start(){
        FunctionReset();
    }
    public void FunctionReset()
    {
        //RESET VALUES
        Variables_Diversion.instance.puntaje = 0f;
        Variables_Diversion.instance.savedTime = 0f;
        Variables_Diversion.instance.attempts = 1f;
        Variables_Diversion.instance.vidas_carrera = 3;
        Variables_Diversion.instance.monedas = 0;
        Variables_Diversion.instance.puntaje = 0f;
        Variables_Diversion.instance.coin1 = true;
        Variables_Diversion.instance.coin2 = true;
        Variables_Diversion.instance.coin3 = true;
        Variables_Diversion.instance.status = "Start";
    }

}
