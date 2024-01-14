using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScoreCarrera : MonoBehaviour
{
    public Text positionToClone;
    public Text scoreToClone;
    public Text timeToClone;
    public Text nameToClone;
    public GameObject componentParent;
    int numClones = 10;
    int position_y = 1130;
    int decrement = 190;
    string positionByPlayer = "...";
    string scoreByPlayer = "...";
    string timeByPlayer = "...";
    string nameByPlayer = "...";


    void Start()
    {
        ShowScorePlayers();
    }

    List<ObjectScoreDiversion> LoadScore()
    {
        string tipo_juego = Variables_Diversion.instance.tipo_juego;
        ObjectThemeDiversion container = SaveLoadDataDiversion.LoadThemes<ObjectThemeDiversion>("Diversion", tipo_juego);

        return container.players_score;
    }
    void ShowScorePlayers()
    {
        List<ObjectScoreDiversion> data_players = LoadScore();
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



            //TIME
            Text timeChildren = Instantiate(timeToClone, new Vector3(0, 0, 0), Quaternion.identity);
            timeChildren.transform.SetParent(componentParent.transform);
            if (i < cant_players)
            {
                timeByPlayer = data_players[i].time.ToString();
            }
            timeChildren.text = timeByPlayer;
            timeChildren.rectTransform.localPosition = new Vector3(timeToClone.rectTransform.localPosition.x, position_y, timeToClone.rectTransform.localPosition.z);
            timeChildren.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            timeChildren.gameObject.SetActive(true);

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
            timeByPlayer = "...";
            nameByPlayer = "...";
            position_y -= decrement;
        }

    }


}
