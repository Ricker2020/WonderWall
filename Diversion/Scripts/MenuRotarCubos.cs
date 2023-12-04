using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuRotarCubos : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    // Update is called once per frame
    public float rotationSpeed = 20f;
    bool rotate=false;
    int timeRotate=0;
    bool one=true;
    bool two=false;

    void Update(){
        Vector3 rotationEulerAngles = transform.rotation.eulerAngles;
        if(rotationEulerAngles.y<180.0f && one){
            RotateObject();
            two=true;
            one=false;
        }

        if(rotationEulerAngles.y<180.0f && two ){
            RotateObject();
            one=true;
        }

    }

    void RotateObject()
    {
        // Rotar el objeto alrededor del eje Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        rotate=true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        rotate=false;
    }
}
