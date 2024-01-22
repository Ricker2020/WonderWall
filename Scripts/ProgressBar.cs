using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider bar;
    public Text progressText;

    public void UpdateProgressBar(float currentValue, float maxValue){
        float percentage=currentValue/maxValue;
        bar.value=percentage;
        progressText.text=(percentage*100).ToString("F2") +"%";

    }

   
}
