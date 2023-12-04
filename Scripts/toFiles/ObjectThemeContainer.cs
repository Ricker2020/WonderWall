using System.Collections.Generic;
[System.Serializable]
public class ObjectThemeContainer
{
    public List<ObjectTheme> dataList;

    public ObjectThemeContainer(List<ObjectTheme> data)
    {
        dataList = data;
    }
}