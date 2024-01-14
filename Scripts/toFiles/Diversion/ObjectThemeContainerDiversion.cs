using System.Collections.Generic;
[System.Serializable]
public class ObjectThemeContainerDiversion
{
    public List<ObjectThemeDiversion> dataList;

    public ObjectThemeContainerDiversion(List<ObjectThemeDiversion> data)
    {
        dataList = data;
    }
}