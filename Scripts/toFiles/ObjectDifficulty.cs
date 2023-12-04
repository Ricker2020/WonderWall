using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectDifficulty
{
    public string difficulty;
    public List<string> themes;

    public ObjectDifficulty(string Difficulty, List<string> Themes){
        difficulty=Difficulty;
        themes=Themes;
    }
}
