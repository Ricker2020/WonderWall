using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saveScoreCarrera : MonoBehaviour
{
    public Text score;
    public Text time;

    void Start()
    {
        score.text=(Variables_Diversion.instance.puntaje).ToString();
        double tiempo=Variables_Diversion.instance.savedTime;
        int minutes = Mathf.FloorToInt((float)(tiempo / 60f));
        int seconds = Mathf.FloorToInt((float)(tiempo % 60f));
        time.text=minutes+"m::"+seconds+"s";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
