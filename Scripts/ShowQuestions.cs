using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowQuestions : MonoBehaviour
{
    /*public TextMeshProUGUI  question;
    public TextMeshProUGUI  answer;*/
    //public Text question;
    //public Text  answer;

    public InputField question;
    public InputField answer;


    public Button buttonLeft;
    public Button buttonRight;

    public Text theme_text;
    public Text number_question;

    public GameObject normal_question;
    public GameObject last_question;

    //TO UPDATE
    public GameObject view_question;



    int cant_questions=0;
    int size_data=0;


    string theme_;
    bool reload=true;
    bool reload_view=true;

    List<ObjectData> data_current;

    void Start()
    {
        buttonLeft.onClick.AddListener(() => ChangeQuestion(-1));
        buttonRight.onClick.AddListener(() => ChangeQuestion(1));
        CurrentData();
    }



    void Update(){
        if((gameObject.activeSelf && reload) || (view_question.activeSelf && reload_view)){
            Variables_Game.instance.changeFileThemes+=1;
            reload=false;
            reload_view=false;
            CurrentData();
        }
        else if (!view_question.activeSelf && !reload_view){
            reload_view=true;
            
        }
    }

    void OnDisable(){
        reload=true;
    }
    
    void CurrentData(){
        buttonLeft.gameObject.SetActive(true);
        buttonRight.gameObject.SetActive(true);
        theme_=Variables_Game.instance.selectedTheme.name_file;
        cant_questions=0;
        string difficulty=Variables_Game.instance.difficulty;
        ObjectDataContainer container = SaveLoadData.LoadData<ObjectDataContainer>("FilesGame/Difficulty/"+difficulty+"/Questions", theme_);
    
        data_current = container.dataList;
        size_data=data_current.Count;

        if(size_data==0){
            last_question.SetActive(true);
            normal_question.SetActive(false);
        }
        else if(size_data==1){
            question.text=data_current[0].question;
            answer.text=data_current[0].answer;
            theme_text.text=theme_;
            number_question.text=(cant_questions+1).ToString();

            buttonLeft.gameObject.SetActive(false);
            buttonRight.gameObject.SetActive(false);
        }
        else if(size_data>1){
            question.text=data_current[0].question;
            answer.text=data_current[0].answer;
            theme_text.text=theme_;
            number_question.text=(cant_questions+1).ToString();
        }
    }
        
    void ChangeQuestion(int direction)
    {
        buttonLeft.gameObject.SetActive(true);
        buttonRight.gameObject.SetActive(true);

        if(direction==-1){
            cant_questions-=1;
        }
        else{
            cant_questions+=1;
        }

        if(cant_questions==size_data+1){
            cant_questions=1;
            buttonLeft.gameObject.SetActive(false);
        }
        if(cant_questions<=0){
            cant_questions=size_data;
            buttonRight.gameObject.SetActive(false);
        }
        question.text=data_current[cant_questions-1].question;
        answer.text=data_current[cant_questions-1].answer;

        theme_text.text=theme_;
        number_question.text=(cant_questions).ToString();

        //text_view.text=cant_questions.ToString();

        //Variables_Game.instance.cantQuestions=cant_questions;

    }

}
