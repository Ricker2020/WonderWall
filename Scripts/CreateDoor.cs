using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;

public class CreateDoor : MonoBehaviour
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


    //progress bar
    public ProgressBar progressBar;

    //DIFFICULTY
    float timeToCreate=15.0f; //10
    float speed_current=1.5f;  //5


    public Text text_score_player;


    void Start()
    {
        
        //RESET VALUES
        Variables_Game.instance.current_score = 0;
        Variables_Game.instance.combo_in_score = -1;

        cant_questions=Variables_Game.instance.cantQuestions;

        progressBar = FindObjectOfType<ProgressBar>();

        

        //save_score.SetActive(false);
        //after_game.SetActive(false);

        
        
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
        //buttonSave.onClick.AddListener(SaveScore);


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
                timeToCreate=timeToCreate*0.7f;
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
        DoorAction doorScript = instantiatedDoor.GetComponent<DoorAction>();
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
        in_game.SetActive(false);
        text_score_player.text=(Variables_Game.instance.current_score).ToString();
        //Variables_Game.instance.endGame=true;
        Variables_Game.instance.status="End";
    }
    



    


    







}
