using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionConfirm : MonoBehaviour
{
    public Text dialog;
    public GameObject view;
    public GameObject close;


    public string option;
    public List<ObjectData> questionList;

    string theme_;
    string difficulty;
    
    public void StartDialog()
    {
        theme_=Variables_Game.instance.selectedTheme.name_file;
        difficulty=Variables_Game.instance.difficulty;
        switch(option){
            case "add":
                dialog.text = "¿Estás seguro de añadir esta pregunta?";
                break;
            case "save":
                dialog.text = "¿Estás seguro de editar esta pregunta?";
                break;
            case "delete":
                dialog.text = "¿Estás seguro de eliminar esta pregunta?";
                break;
        }
        //Confirm();
    }

    public void Confirm(){
        ObjectDataContainer container = new ObjectDataContainer(questionList);
        SaveLoadData.SaveData(container, "FilesGame/Difficulty/"+difficulty+"/Questions", theme_);
    
        switch(option){
            case "add":
                dialog.text = "Se ha agregadó la pregunta";
                break;
            case "save":
                dialog.text = "Se ha editadó la pregunta";
                break;
            case "delete":
                dialog.text = "Se ha eliminado la pregunta";
                break;
        }
    }

    public void Close(){
        view.SetActive(true);
        close.SetActive(true);
        Destroy (gameObject);
        //
        //gameObject.SetActive(false);
    }

}
