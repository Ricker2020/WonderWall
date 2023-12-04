using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public static class SaveLoadData
{

    public static string ruteData(){
        return Application.persistentDataPath;
    }


    public static bool ruteComprovate(){
        string fullPath = ruteData()+"/FilesGame/Difficulty";
        bool checkFolderExit = Directory.Exists(fullPath);
        return checkFolderExit;
    }


    public static void SaveData<T>(T data, string path, string filename)
    {
        string fullPath = ruteData()+"/"+path+"/";
        bool checkFolderExit = Directory.Exists(fullPath);
        if (checkFolderExit == false)
        {
            Directory.CreateDirectory(fullPath);
        }
        
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(fullPath + filename + ".json", json);
    }


    //APARTADO DE PREGUNTAS
    public static ObjectDataContainer LoadData<T>(string path, string filename){
        //string fullPath=Application.persistentDataPath+"/"+path+"/"+filename+".json";
        //string fullPath="Assets/FilesQuestions/Ingles.json";
        string fullPath=ruteData()+"/"+path+"/"+filename+".json";
        if(File.Exists(fullPath)){
            string textJson=File.ReadAllText(fullPath);
            ObjectDataContainer container=JsonUtility.FromJson<ObjectDataContainer>(textJson);
            return container;
        }
        else{
            return default;
        }
        
    }

    //APARTADO DE THEMES
    public static ObjectThemeContainer LoadThemes<T>(string path, string filename){
        string fullPath=ruteData()+"/"+path+"/"+filename+".json";
        if(File.Exists(fullPath)){
            string textJson=File.ReadAllText(fullPath);
            ObjectThemeContainer container=JsonUtility.FromJson<ObjectThemeContainer>(textJson);
            return container;
        }
        else{
            return default;
        }
        
    }

    public static void DeleteFile(string path, string filename){
        string fullPath=ruteData()+"/"+path+"/"+filename+".json";
        if (File.Exists(fullPath)) {
            File.Delete(fullPath);
        }
    }

}
