using System.Collections.Generic;
[System.Serializable]
public class ObjectDifficultyContainer
{
    public List<ObjectDifficulty> dataList;

    public ObjectDifficultyContainer(List<ObjectDifficulty> data)
    {
        dataList = data;
    }
}