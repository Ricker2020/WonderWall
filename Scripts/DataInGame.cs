using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataInGame : MonoBehaviour
{
    public GameObject question;
    public GameObject generateData;
    void Start()
    {
        //Si existe datos
        if(SaveLoadData.ruteComprovate()){
            question.SetActive(true);
            generateData.SetActive(false);
        }else{
            question.SetActive(false);
            generateData.SetActive(true);
        }

    }

    public void GenerateData(){
        question.SetActive(false);
        generateData.SetActive(true);
    }
}
