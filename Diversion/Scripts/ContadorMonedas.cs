using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorMonedas : MonoBehaviour
{
    int coin_current;
    public GameObject coin1;
    public GameObject coin2;
    public GameObject coin3;

    public GameObject moneda1;
    public GameObject moneda2;
    public GameObject moneda3;

    void Start()
    {
        coin_current=0;
    }

    void Update()
    {
        if(Variables_Diversion.instance.monedas!=coin_current){
            coin_current=Variables_Diversion.instance.monedas;
            //Hace visible/no visible en la pista
            moneda1.SetActive(Variables_Diversion.instance.coin1);
            moneda2.SetActive(Variables_Diversion.instance.coin2);
            moneda3.SetActive(Variables_Diversion.instance.coin3);
            
            if(coin_current==1){
                coin1.SetActive(true);
            }
            if(coin_current==2){
                coin1.SetActive(true);
                coin2.SetActive(true);
            }
            if(coin_current==3){
                coin1.SetActive(true);
                coin2.SetActive(true);
                coin3.SetActive(true);
            }
        }
    }
}
