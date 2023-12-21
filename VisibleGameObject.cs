using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleGameObject : MonoBehaviour
{
    public GameObject stateObject;
    public bool state=false;
    void Start()
    {
        stateObject.SetActive(state);
        
    }

}
