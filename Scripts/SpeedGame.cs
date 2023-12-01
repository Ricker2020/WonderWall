using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedGame : MonoBehaviour
{
    public ProgressBar progressBar;

    float speed_current=3.0f;
    
    public void ChangePorcentage(int current){
        progressBar = FindObjectOfType<ProgressBar>();
        progressBar.UpdateProgressBar(current, 4);

    }

    public void ChangeSpeed(string increment){
        Variables_Game.instance.increment_speed=increment;
    }
}
