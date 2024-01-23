using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectTheme
{
    public string title;
    public string name_file;
    public string description; //
    public List<ObjectScore> players_score;

    public ObjectTheme(string Title, string NameFile, string Description, List<ObjectScore> PlayersScore){
        title=Title;
        name_file=NameFile;
        description=Description; //
        players_score=PlayersScore;
    }
}
