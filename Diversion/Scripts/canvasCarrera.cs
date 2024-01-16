using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasCarrera : MonoBehaviour
{
    public  GameObject inGame;
    public  GameObject saveScore;
    int time=0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Variables_Diversion.instance.status=="End" && time==0){
            inGame.SetActive(false);
            saveScore.SetActive(true);
            time=1;
        }
        
    }
}
