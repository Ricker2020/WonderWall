using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleScore : MonoBehaviour
{
    public Text title;
    void Start()
    {
        string dificultad = "";
        switch (Variables_Game.instance.difficulty)
        {
            case "Easy":
                dificultad = "Fácil";
                break;
            case "Medium":
                dificultad = "Medio";
                break;
            case "Hard":
                dificultad = "Difícil";
                break;
        }

        title.text = "Dificultad ("+dificultad+") Tema (" +Variables_Game.instance.selectedTheme.title+")";


    }

}
