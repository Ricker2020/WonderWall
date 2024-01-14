using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectThemeDiversion
{
    public string title;
    public List<ObjectScoreDiversion> players_score;

    public ObjectThemeDiversion(string Title, List<ObjectScoreDiversion> PlayersScore){
        title=Title;
        players_score=PlayersScore;
    }
}
