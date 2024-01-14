using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public static class SaveLoadDataDiversion
{

    public static string ruteData()
    {
        return Application.persistentDataPath;
    }


    public static ObjectThemeDiversion LoadThemes<T>(string path, string filename)
    {
        string fullPath = ruteData() + "/" + path + "/" + filename + ".json";
        if (File.Exists(fullPath))
        {
            string textJson = File.ReadAllText(fullPath);
            ObjectThemeDiversion container = JsonUtility.FromJson<ObjectThemeDiversion>(textJson);
            return container;
        }
        else
        {
            return default;
        }

    }

    public static void SaveData<T>(T data, string path, string filename)
    {
        string fullPath = ruteData() + "/" + path + "/";
        bool checkFolderExit = Directory.Exists(fullPath);
        if (checkFolderExit == false)
        {
            Directory.CreateDirectory(fullPath);
        }

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(fullPath + filename + ".json", json);
    }

    public static void ResetDataDefault(string path, string filename)
    {
        ObjectThemeDiversion dataList =  new ObjectThemeDiversion(filename,new List<ObjectScoreDiversion>());

        string fullPath = ruteData() + "/" + path + "/";
        bool checkFolderExit = Directory.Exists(fullPath);
        if (checkFolderExit == false)
        {
            Directory.CreateDirectory(fullPath);
        }

        string json = JsonUtility.ToJson(dataList);
        File.WriteAllText(fullPath + filename + ".json", json);
    }




}
