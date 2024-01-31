using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;
public class ActiveSaveScore : MonoBehaviour
{
    public GameObject save_score;
    public GameObject after_game;


    public Text positionToClone;
    public Text scoreToClone;
    public Text nameToClone;
    public GameObject componentParent;


    public Text name_player;

    int numClones = 10;
    int position_y = 1105;
    int decrement = 190;
    string positionByPlayer = "...";
    string scoreByPlayer = "...";
    string nameByPlayer = "...";





    bool first_time=true;


    void Update(){
        if(Variables_Game.instance.status=="End" && first_time){
            save_score.SetActive(true);
            first_time=false;
        }
    }


    public void SaveScore()
    {
        string name = name_player.text;
        string difficulty = Variables_Game.instance.difficulty;
        ObjectThemeContainer container = SaveLoadData.LoadThemes<ObjectThemeContainer>("FilesGame/Difficulty/" + difficulty, "themes" + difficulty);
        List<ObjectTheme> data_current = container.dataList;

        for (int i = 0; i < data_current.Count; i++)
        {
            if (data_current[i].name_file == Variables_Game.instance.selectedTheme.name_file)
            {
                data_current[i].players_score.Add(new ObjectScore(name, Variables_Game.instance.current_score));
                data_current[i].players_score = SortScores(data_current[i].players_score);
                break;
            }
        }
        container.dataList = data_current;
        SaveLoadData.SaveData(container, "FilesGame/Difficulty/" + difficulty, "themes" + difficulty);

        //RESET VALUES
        Variables_Game.instance.current_score = 0;
        Variables_Game.instance.combo_in_score = -1;

   


        save_score.SetActive(false);
        after_game.SetActive(true);

        //NEXT I SHOW THE SCORE IN TEXT'S
        ShowScorePlayers();
    }


    //CREATE TEXT'S OBJECT
    void ShowScorePlayers()
    {
        List<ObjectScore> data_players = LoadScore();
        int cant_players = data_players.Count;
        for (int i = 0; i < numClones; i++)
        {
            //POSITION
            Text positionChildren = Instantiate(positionToClone, new Vector3(0, 0, 0), Quaternion.identity);
            positionChildren.transform.SetParent(componentParent.transform);
            switch (i)
            {
                case 0:
                    positionByPlayer = "ST.";
                    break;
                case 1:
                    positionByPlayer = "ND.";
                    break;
                case 2:
                    positionByPlayer = "RD.";
                    break;
                default:
                    positionByPlayer = "TH.";
                    break;
            }
            positionChildren.text = (i + 1).ToString() + positionByPlayer;
            positionChildren.rectTransform.localPosition = new Vector3(positionToClone.rectTransform.localPosition.x, position_y, positionToClone.rectTransform.localPosition.z);
            positionChildren.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            positionChildren.gameObject.SetActive(true);


            //SCORE
            Text scoreChildren = Instantiate(scoreToClone, new Vector3(0, 0, 0), Quaternion.identity);
            scoreChildren.transform.SetParent(componentParent.transform);
            if (i < cant_players)
            {
                scoreByPlayer = data_players[i].score.ToString();
            }
            scoreChildren.text = scoreByPlayer;
            scoreChildren.rectTransform.localPosition = new Vector3(scoreToClone.rectTransform.localPosition.x, position_y, scoreToClone.rectTransform.localPosition.z);
            scoreChildren.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            scoreChildren.gameObject.SetActive(true);

            //NAME
            Text nameChildren = Instantiate(nameToClone, new Vector3(0, 0, 0), Quaternion.identity);
            nameChildren.transform.SetParent(componentParent.transform);
            if (i < cant_players)
            {
                nameByPlayer = data_players[i].name;
                scoreByPlayer = data_players[i].score.ToString();
            }
            nameChildren.text = nameByPlayer;
            nameChildren.rectTransform.localPosition = new Vector3(nameToClone.rectTransform.localPosition.x, position_y, nameToClone.rectTransform.localPosition.z);
            nameChildren.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            nameChildren.gameObject.SetActive(true);

            //RESET VALUES && DECREMENT
            scoreByPlayer = "...";
            nameByPlayer = "...";
            position_y -= decrement;
        }

    }


    List<ObjectScore> LoadScore()
    {
        string difficulty = Variables_Game.instance.difficulty;
        ObjectThemeContainer container = SaveLoadData.LoadThemes<ObjectThemeContainer>("FilesGame/Difficulty/" + difficulty, "themes" + difficulty);
        List<ObjectTheme> data_current = container.dataList;
        List<ObjectScore> data_players = new List<ObjectScore>();

        for (int i = 0; i < data_current.Count; i++)
        {
            if (data_current[i].name_file == Variables_Game.instance.selectedTheme.name_file)
            {
                data_players = data_current[i].players_score;
                break;
            }
        }
        return data_players;
    }

    List<ObjectScore> SortScores(List<ObjectScore> scores)
    {
        scores.Sort((x, y) => y.score.CompareTo(x.score));
        //Keeps only 10 score elements
        if (scores.Count > 10)
        {
            scores = scores.Take(10).ToList();
        }
        return scores;
    }



}
