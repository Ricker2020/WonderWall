using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTime : MonoBehaviour
{
    public Text score;
    public Text time;

    bool increment = true;
    double tiempo;
    void Start()
    {
        Variables_Diversion.instance.puntaje = 0f;
        Variables_Diversion.instance.savedTime = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (Variables_Diversion.instance.status != "End")
        {
            if (increment)
            {
                increment = false;


                Variables_Diversion.instance.puntaje += 10f;
                Variables_Diversion.instance.savedTime += 1f;
                tiempo = Variables_Diversion.instance.savedTime;

                score.text = (Variables_Diversion.instance.puntaje).ToString();

                int minutes = Mathf.FloorToInt((float)(tiempo / 60f));
                int seconds = Mathf.FloorToInt((float)(tiempo % 60f));
                time.text = minutes + "m::" + seconds + "s";
                Invoke("cooldown_activate", 1.0f);

            }

        }

    }

    void cooldown_activate()
    {
        increment = true;
    }
}
