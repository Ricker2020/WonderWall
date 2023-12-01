using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsPlayer : MonoBehaviour
{
    public Button buttonQuestions;
    public Button buttonLeft;
    public Button buttonRight;
    public Text text_view;
    public Text text_theme;
    public Text text_title;

    public GameObject quantity;
    public Text details;

   
    int cant_questions=0;
    int size_data=0;


    bool reload=true;

    void Start()
    {
        buttonQuestions.onClick.AddListener(ObtenerTexto);
        buttonLeft.onClick.AddListener(() => ChangeCant(-1));
        buttonRight.onClick.AddListener(() => ChangeCant(1));
        CurrentData();
    }

    void Update(){
        if(gameObject.activeSelf && reload){
            Variables_Game.instance.changeFileThemes+=1;
            reload=false;
            CurrentData();
        }
    }

    void OnDisable(){
        reload=true;
    }

    void CurrentData(){
        //theme_=Variables_Game.instance.selectedTheme.name_file;
        cant_questions=0;
        string difficulty=Variables_Game.instance.difficulty;
        ObjectDataContainer container = SaveLoadData.LoadData<ObjectDataContainer>("FilesGame/Difficulty/"+difficulty+"/Questions", Variables_Game.instance.selectedTheme.name_file);
        List<ObjectData> data_current = container.dataList;
        size_data=data_current.Count;
        cant_questions=size_data;
        text_theme.text=Variables_Game.instance.selectedTheme.title;

        if(size_data==0){
            quantity.SetActive(false);
            details.gameObject.SetActive(true);
            text_title.gameObject.SetActive(false);
        }else{
            text_view.text = cant_questions.ToString();
            quantity.SetActive(true);
            details.gameObject.SetActive(false);
            text_title.gameObject.SetActive(true);

        }
    }

    void ObtenerTexto()
    {
        Variables_Game.instance.cantQuestions=cant_questions;
    }

    void ChangeCant(int direction)
    {
        if(direction==-1){
            cant_questions-=1;
        }
        else{
            cant_questions+=1;
        }

        if(cant_questions==size_data+1){
            cant_questions=1;
        }
        if(cant_questions<=0){
            cant_questions=size_data;
        }
        text_view.text=cant_questions.ToString();

        //Variables_Game.instance.cantQuestions=cant_questions;

    }
}
