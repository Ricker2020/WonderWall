using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;

public class CreateDoorFly : MonoBehaviour
{

    public GameObject door;
    bool cooldown=true;

    int position_data_questions=0;
    public int size_data;
    public int cant_questions;


    List<ObjectData> data_current;
    List<string> bad_answer=new List<string>(); 

    //SCORE
    public Text score_general;
    int score_=0;

    //COMBO
    public Text combo_general;
    int combo_=-1;

    //COMPONENT
    public GameObject in_game;
    public GameObject save_score;
    public GameObject after_game;

    //SHOW SCORE
    Text text_score_player;

    //SAVE SCORE
    public Button buttonSave;
    public Text name_player;

    //progress bar
    public ProgressBar progressBar;

    //DIFFICULTY
    float timeToCreate=13.0f; //10
    float speed_current=2.0f;  //5


    void Start()
    {
        
        //Variables_Game.instance.endGame=false;
        //Variables_Game.instance.status="Start";

        cant_questions=Variables_Game.instance.cantQuestions;

        progressBar = FindObjectOfType<ProgressBar>();

        

        save_score.SetActive(false);
        after_game.SetActive(false);

        Transform childScore = save_score.transform.GetChild(0);
        text_score_player = childScore.GetComponent<Text>();
        score_general.text=(Variables_Game.instance.current_score).ToString();

        
        
        System.Random random = new System.Random();
        string difficulty=Variables_Game.instance.difficulty;
        ObjectDataContainer container2 = SaveLoadData.LoadData<ObjectDataContainer>("FilesGame/Difficulty/"+difficulty+"/Questions", Variables_Game.instance.selectedTheme.name_file);
        data_current = container2.dataList;
        size_data=data_current.Count;

        //Desordenar la data
        for (int i = 0; i < data_current.Count; i++) {
            int randomIndex = random.Next(i, data_current.Count);
            ObjectData temp = data_current[i];
            data_current[i] = data_current[randomIndex];
            data_current[randomIndex] = temp;
            string answer2=choose_bad_answer(i,data_current);
            bad_answer.Add(answer2);
        }


        //Save SCORE on click
        buttonSave.onClick.AddListener(SaveScore);


        //Speed
        
        switch (Variables_Game.instance.increment_speed) {
            case "x1.00":
                timeToCreate=timeToCreate*1.0f;
                speed_current=speed_current*1.0f;
                break;
            case "x1.25":
                timeToCreate=timeToCreate*0.9f;
                speed_current=speed_current*1.20f;
                break;
            case "x1.50":
                timeToCreate=timeToCreate*0.8f;
                speed_current=speed_current*1.4f;
                break;
            case "x1.75":
                timeToCreate=timeToCreate*0.7f;
                speed_current=speed_current*1.6f;
                break;
            case "x2.00":
                timeToCreate=timeToCreate*0.6f;
                speed_current=speed_current*1.8f;
                break;
        }
           
    }

   
    void Update()
    {
        if(cooldown && position_data_questions<cant_questions){ 
            cooldown=false;
            Invoke("cooldown_activate", timeToCreate);
        }
        if(score_!=Variables_Game.instance.current_score){
            score_=Variables_Game.instance.current_score;
            score_general.text=(Variables_Game.instance.current_score).ToString();
            combo_general.text=(Variables_Game.instance.combo_in_score+1).ToString();
        }
        if(combo_!=Variables_Game.instance.combo_in_score){
            combo_=Variables_Game.instance.current_score;
            combo_general.text=(Variables_Game.instance.combo_in_score+1).ToString();
        }

        //FIN DE PARTIDA
        if(position_data_questions==cant_questions){
            cooldown=false;
            Invoke("players_score_result", 15.0f);
            cant_questions=+1;
        }
    }

    void cooldown_activate(){
        cooldown=true;
        GameObject instantiatedDoor = Instantiate(door);
        DoorActionFly doorScript = instantiatedDoor.GetComponent<DoorActionFly>();
        doorScript.text_question = data_current[position_data_questions].question;
        
        doorScript.speed=speed_current;
        /*
        if(Variables_Game.instance.difficulty!="Easy"){
            speed_current+=0.4f;
            timeToCreate-=0.1f;
        }*/

        System.Random random2 = new System.Random();

        int randomIndex2 = random2.Next(0, 10);
        if(randomIndex2<5){
            doorScript.text_answer1 = data_current[position_data_questions].answer;
            doorScript.text_answer2 = bad_answer[position_data_questions];
            doorScript.position_correct=1;

        }
        else{
            doorScript.text_answer1 = bad_answer[position_data_questions];
            doorScript.text_answer2 = data_current[position_data_questions].answer;
            doorScript.position_correct=2;
        }

        
        position_data_questions+=1;
        progressBar.UpdateProgressBar(position_data_questions, cant_questions);
    }
    /*
    string choose_bad_answer(string str1, List<ObjectData> data) {
        System.Random random3 = new System.Random();
        ObjectData bad_result = data[random3.Next(0, data.Count)];

        while ((bad_result.answer).Trim() == (str1).Trim()) {
            bad_result = data[random3.Next(0, data.Count)];
        }
        return bad_result.answer;
    }*/


    string choose_bad_answer(int index, List<ObjectData> data) {
        System.Random random3 = new System.Random();
        int randomIndex=random3.Next(0, data.Count);

        while (randomIndex == index) {
           randomIndex=random3.Next(0, data.Count);
        }
        return data[randomIndex].answer;
    }

    void players_score_result(){
        save_score.SetActive(true);
        in_game.SetActive(false);
        after_game.SetActive(false); //

        text_score_player.text=(Variables_Game.instance.current_score).ToString();
        //Variables_Game.instance.endGame=true;
        Variables_Game.instance.status="End";
    }
    
    void SaveScore(){
        string name=name_player.text;
        string difficulty=Variables_Game.instance.difficulty;
        ObjectThemeContainer container = SaveLoadData.LoadThemes<ObjectThemeContainer>("FilesGame/Difficulty/"+difficulty, "themes"+difficulty);
        List<ObjectTheme> data_current = container.dataList;

        for (int i = 0; i < data_current.Count; i++) {
            if(data_current[i].name_file==Variables_Game.instance.selectedTheme.name_file){
                data_current[i].players_score.Add(new ObjectScore(name,Variables_Game.instance.current_score));
                data_current[i].players_score=SortScores(data_current[i].players_score);
                break;
            }
        }
        container.dataList=data_current;
        SaveLoadData.SaveData(container, "FilesGame/Difficulty/"+difficulty, "themes"+difficulty);

        //RESET VALUES
        Variables_Game.instance.current_score=0;
        Variables_Game.instance.combo_in_score=-1;

        after_game.SetActive(true);
        save_score.SetActive(false);

        //NEXT I SHOW THE SCORE IN TEXT'S
        ShowScorePlayers();
    }

    public Text positionToClone;
    public Text scoreToClone;
    public Text nameToClone;
    public GameObject componentParent;
    int numClones = 10;
    int position_y=1380;
    int decrement=190;
    string positionByPlayer="...";
    string scoreByPlayer="...";
    string nameByPlayer="...";
    


    //CREATE TEXT'S OBJECT
    void ShowScorePlayers(){
        List<ObjectScore> data_players=LoadScore();
        int cant_players=data_players.Count;
        for (int i = 0; i < numClones; i++)
        {
            //POSITION
            Text positionChildren = Instantiate(positionToClone, new Vector3(0,0,0), Quaternion.identity);            
            positionChildren.transform.SetParent(componentParent.transform);
            switch (i) {
                case 0:
                    positionByPlayer="ST.";
                    break;
                case 1:
                    positionByPlayer="ND.";
                    break;
                case 2:
                    positionByPlayer="RD.";
                    break;
                default:
                    positionByPlayer="TH.";
                    break;
            }
            positionChildren.text = (i+1).ToString()+positionByPlayer;
            positionChildren.rectTransform.localPosition = new Vector3(positionToClone.rectTransform.localPosition.x, position_y, positionToClone.rectTransform.localPosition.z);
            positionChildren.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            positionChildren.gameObject.SetActive(true);


            //SCORE
            Text scoreChildren = Instantiate(scoreToClone, new Vector3(0,0,0), Quaternion.identity);            
            scoreChildren.transform.SetParent(componentParent.transform);
            if(i<cant_players){
                scoreByPlayer=data_players[i].score.ToString();
            }
            scoreChildren.text =scoreByPlayer;
            scoreChildren.rectTransform.localPosition = new Vector3(scoreToClone.rectTransform.localPosition.x, position_y, scoreToClone.rectTransform.localPosition.z);
            scoreChildren.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            scoreChildren.gameObject.SetActive(true);

            //NAME
            Text nameChildren = Instantiate(nameToClone, new Vector3(0,0,0), Quaternion.identity);            
            nameChildren.transform.SetParent(componentParent.transform);
            if(i<cant_players){
                nameByPlayer=data_players[i].name;
                scoreByPlayer=data_players[i].score.ToString();
            }
            nameChildren.text = nameByPlayer;
            nameChildren.rectTransform.localPosition = new Vector3(nameToClone.rectTransform.localPosition.x, position_y, nameToClone.rectTransform.localPosition.z);
            nameChildren.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            nameChildren.gameObject.SetActive(true);

            //RESET VALUES && DECREMENT
            scoreByPlayer="...";
            nameByPlayer="...";
            position_y-=decrement;
        }

    }

    List<ObjectScore> LoadScore(){
        string difficulty=Variables_Game.instance.difficulty;
        ObjectThemeContainer container = SaveLoadData.LoadThemes<ObjectThemeContainer>("FilesGame/Difficulty/"+difficulty, "themes"+difficulty);
        List<ObjectTheme> data_current = container.dataList;
        List<ObjectScore> data_players=new List<ObjectScore>();

        for (int i = 0; i < data_current.Count; i++) {
            if(data_current[i].name_file==Variables_Game.instance.selectedTheme.name_file){
                data_players=data_current[i].players_score;
                break;
            }
        }
        return data_players;
    }

    List<ObjectScore> SortScores(List<ObjectScore> scores) {
        scores.Sort((x, y) => y.score.CompareTo(x.score));
        //Keeps only 10 score elements
        if(scores.Count>10){
            scores = scores.Take(10).ToList();
        }
        return scores;
    }





}
