using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasCarrera : MonoBehaviour
{
    public  GameObject inGame;
    public  GameObject saveScore;
    public  GameObject afterGame;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Variables_Diversion.instance.status=="End"){
            inGame.SetActive(false);
            saveScore.SetActive(true);
        }
        
    }
}
