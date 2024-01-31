using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OptionsTheme : MonoBehaviour
{

    public Text select_theme;
    public GameObject view;
    public Text result_text;

    bool reload=true;


    //Create
    public Text name_theme; 
    public Text description_theme;

    void Start(){
        ShowTheme();
    }

    void Update(){
        if(gameObject.activeSelf && reload){
            Variables_Game.instance.changeFileThemes+=1;
            reload=false;
            ShowTheme();
        }
    }

    void OnDisable(){
        reload=true;
    }

    void ShowTheme(){
       if(select_theme!=null){
            select_theme.text=Variables_Game.instance.selectedTheme.title;
        }
    }


    public void CreateTheme(){
        string nameFile=NameFile(name_theme.text);
        string difficulty=Variables_Game.instance.difficulty;
        ObjectThemeContainer container = SaveLoadData.LoadThemes<ObjectThemeContainer>("FilesGame/Difficulty/"+difficulty, "themes"+difficulty);

        view.SetActive(true);
        if(CheckUnique(container.dataList, nameFile)){
            container.dataList.Add(new ObjectTheme(name_theme.text,nameFile, description_theme.text  ,new List<ObjectScore>())); //
            SaveLoadData.SaveData(container, "FilesGame/Difficulty/"+difficulty, "themes"+difficulty);

            //EMPTY FILE
            List<ObjectData> newList = new List<ObjectData>();
            ObjectDataContainer newContainer = new ObjectDataContainer(newList);
            SaveLoadData.SaveData(newContainer, "FilesGame/Difficulty/"+difficulty+"/Questions", nameFile);
            
            result_text.text="SE HA CREADO EL TEMA "+name_theme.text;
        }else{
            result_text.text="YA EXISTE EL TEMA "+name_theme.text;
        }

        gameObject.SetActive(false);
        //
        //Variables_Game.instance.changeFileThemes=0;
    }

    string NameFile(string name_file){
        string result = name_file.Replace(" ", "");
        result = result.ToLower();
        return result;
    }

    bool CheckUnique(List<ObjectTheme> themeList, string nameFile){
        foreach (ObjectTheme theme in themeList){
            if (theme.name_file == nameFile){
                return false;
            }
        }
        return true;
    }

    public void DeleteTheme(){
        string difficulty=Variables_Game.instance.difficulty;
        SaveLoadData.DeleteFile("FilesGame/Difficulty/"+difficulty+"/Questions", Variables_Game.instance.selectedTheme.name_file);

        ObjectThemeContainer container = SaveLoadData.LoadThemes<ObjectThemeContainer>("FilesGame/Difficulty/"+difficulty, "themes"+difficulty);
        container.dataList.RemoveAll(theme => theme.title == Variables_Game.instance.selectedTheme.title && theme.name_file == Variables_Game.instance.selectedTheme.name_file);
        SaveLoadData.SaveData(container,"FilesGame/Difficulty/"+difficulty, "themes"+difficulty);

        
        //
        //Variables_Game.instance.changeFileThemes=0;
    }






}
