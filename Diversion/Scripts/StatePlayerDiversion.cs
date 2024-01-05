using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePlayerDiversion : MonoBehaviour
{
    public string state;
    void Start()
    {
        Variables_Diversion.instance.status=state;
        
    }
}
