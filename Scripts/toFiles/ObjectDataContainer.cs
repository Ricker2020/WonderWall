using System.Collections.Generic;
[System.Serializable]
public class ObjectDataContainer
{
    public List<ObjectData> dataList;

    public ObjectDataContainer(List<ObjectData> data)
    {
        dataList = data;
    }
}