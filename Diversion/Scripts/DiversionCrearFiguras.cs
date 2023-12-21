using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;

public class DiversionCrearFiguras : MonoBehaviour
{
    public GameObject [] objetos;
    
    bool cooldown=true;
    public float timeToCreate=5.0f;
    int cantidad=0;
    
    void Start()
    {
        
        
    }

    void cooldown_activate(){
        cooldown=true;
        System.Random random3 = new System.Random();
        int randomFigure = random3.Next(0, objetos.Length);
       
        GameObject instantiatedCubo1 = Instantiate(objetos[randomFigure]);
        

    }
    
    void Update()
    {
        if(cooldown && Variables_Diversion.instance.status!="End"){ 
            cooldown=false;
            cantidad=cantidad+1;
            if (cantidad % 10 == 0 && timeToCreate > 3.0f)
            {
                timeToCreate = timeToCreate - 0.3f;
            }
            Invoke("cooldown_activate", timeToCreate);
        }
    }
}
