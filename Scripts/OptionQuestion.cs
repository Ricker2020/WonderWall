using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OptionQuestion : MonoBehaviour
{
    public GameObject dialog;
    public GameObject view;
    public GameObject close;

    //public InputField  question_text;
    
    //public InputField  answer_text;
    //public Transform textTransform;
    public Text question_text;
    public Text answer_text;
    public Text position_text;

    string theme_;
    string difficulty;
    bool reload=true;

    void Start(){
        GetTheme();
    }

    void Update(){
        if(gameObject.activeSelf && reload){
            Variables_Game.instance.changeFileThemes+=1;
            reload=false;
            GetTheme();
        }
    }

    void OnDisable(){
        reload=true;
    }

    void GetTheme(){
        theme_=Variables_Game.instance.selectedTheme.name_file;
        difficulty=Variables_Game.instance.difficulty;
    }

    public void Option(string option){
        
        List<ObjectData> question_list=new List<ObjectData>();

        
        switch(option){
            case "add":
                question_list=AddQuestion(new ObjectData(question_text.text, answer_text.text));
                //Reset Values
                //question_text.text="";
                //answer_text.text="";
                break;
            case "save":
                question_list=EditQuestion(new ObjectData(question_text.text,answer_text.text), Convert.ToInt32(position_text.text));
                break;
            case "delete":
                question_list=DeleteQuestion(Convert.ToInt32(position_text.text));
                break;
        }
      

        GameObject instantiatedDialog = Instantiate(dialog, transform);
        OptionConfirm dialogScript = instantiatedDialog.GetComponent<OptionConfirm>();
        dialogScript.option=option;
        dialogScript.questionList=question_list;
        dialogScript.view=view;
        dialogScript.close=close;
        dialogScript.StartDialog();

        close.SetActive(false);
        view.SetActive(false);

    }

    public List<ObjectData> AddQuestion(ObjectData question){
        
        ObjectDataContainer container = SaveLoadData.LoadData<ObjectDataContainer>("FilesGame/Difficulty/"+difficulty+"/Questions", theme_);
        container.dataList.Add(question);
        return container.dataList;
    }

    public List<ObjectData> EditQuestion(ObjectData question, int position){
        ObjectDataContainer container = SaveLoadData.LoadData<ObjectDataContainer>("FilesGame/Difficulty/"+difficulty+"/Questions", theme_);
        container.dataList[position-1]=question;
        return container.dataList;
    }

    public List<ObjectData> DeleteQuestion(int position){
        ObjectDataContainer container = SaveLoadData.LoadData<ObjectDataContainer>("FilesGame/Difficulty/"+difficulty+"/Questions", theme_);
        container.dataList.RemoveAt(position-1);
        return container.dataList;
    }
}
