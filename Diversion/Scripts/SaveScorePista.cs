using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;

public class SaveScorePista : MonoBehaviour
{
    public Text attempt;
    public Text time;
    public Text name_player;
    public GameObject save_score;
    public GameObject after_game;

    void Start()
    {
        attempt.text = (Variables_Diversion.instance.attempts).ToString();
        double tiempo = Variables_Diversion.instance.savedTime;
        int minutes = Mathf.FloorToInt((float)(tiempo / 60f));
        int seconds = Mathf.FloorToInt((float)(tiempo % 60f));
        time.text = minutes + "m::" + seconds + "s";
        //SaveScore();

    }



    public void SaveScore()
    {
        string name = name_player.text;
        string tipo_juego = Variables_Diversion.instance.tipo_juego;

        ObjectThemeDiversion container = SaveLoadDataDiversion.LoadThemes<ObjectThemeDiversion>("Diversion", tipo_juego);
        container.players_score.Add(new ObjectScoreDiversion(name, Variables_Diversion.instance.attempts, Variables_Diversion.instance.savedTime)); //change score by attemps
        container.players_score = SortScores(container.players_score);

        SaveLoadDataDiversion.SaveData(container, "Diversion", tipo_juego);

        //RESET VALUES
        Variables_Diversion.instance.puntaje = 0f;
        Variables_Diversion.instance.savedTime = 0f;

        after_game.SetActive(true);
        save_score.SetActive(false);
    }

    List<ObjectScoreDiversion> SortScores(List<ObjectScoreDiversion> scores)
    {
        scores.Sort((x, y) => y.time.CompareTo(x.time));
        //Keeps only 10 score elements
        if (scores.Count > 10)
        {
            scores = scores.Take(10).ToList();
        }
        return scores;
    }
}
