using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectTheme
{
    public string title;
    public string name_file;
    public List<ObjectScore> players_score;

    public ObjectTheme(string Title, string NameFile, List<ObjectScore> PlayersScore){
        title=Title;
        name_file=NameFile;
        players_score=PlayersScore;
    }
}
