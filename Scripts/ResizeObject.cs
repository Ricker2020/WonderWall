using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeObject : MonoBehaviour
{
    float value = 500.0f;
    RectTransform rectTransform;
    int direction=-1;
    float increment=1.0f;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        if(value>=500.0f){
            direction=-1;
        }else if(value<=400.0f){
            direction=1;
        }
        value=value+(increment*direction);
        rectTransform.sizeDelta = new Vector2(value, value);
    }
}
