using UnityEngine;
[System.Serializable]
public class ObjectScoreDiversion
{
    public string name;
    public double time;
    public double score;

    public ObjectScoreDiversion(string Name, double Score, double Time){
        name=Name;
        time=Time;
        score=Score;
    }

}
