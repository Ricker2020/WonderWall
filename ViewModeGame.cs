using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewModeGame : MonoBehaviour
{
    public GameObject mode1;
    public GameObject mode2;
    public GameObject model_own;
    public GameObject model_duck;
    public GameObject model_capybara;
    public GameObject model_human;
    public GameObject model_robot;
    public GameObject model_phoenix;
    public Text name_model;
    string mode_current = "";


    void Update()
    {
        if (mode_current != Variables_Game.instance.mode_game)
        {
            mode_current = Variables_Game.instance.mode_game;
            if (Variables_Game.instance.mode_game == "Game")
            {
                mode1.SetActive(true);
                mode2.SetActive(false);
                Variables_Game.instance.player_model = "PATO";
                name_model.text = "PATO";
                EnableModels();
                model_duck.SetActive(true);

            }
            else
            {
                mode1.SetActive(false);
                mode2.SetActive(true);
                Variables_Game.instance.player_model = "BÚHO";
                name_model.text = "BÚHO";
                EnableModels();
                model_own.SetActive(true);
            }
        }

    }

    void EnableModels()
    {
        model_own.SetActive(false);
        model_duck.SetActive(false);
        model_capybara.SetActive(false);
        model_human.SetActive(false);
        model_robot.SetActive(false);
        model_phoenix.SetActive(false);
    }




}
