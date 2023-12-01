using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinModel : MonoBehaviour
{
    public GameObject model;
    bool spin=false;
    float rotationSpeed = 40f;

    void Update(){
        if(spin){
            model.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }
    
    public void SpinValue(){
        spin=!spin;
    }
}
