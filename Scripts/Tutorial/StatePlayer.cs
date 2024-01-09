using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePlayer : MonoBehaviour
{
    public string state;
    void Start()
    {
        Variables_Game.instance.status=state;
    }
    


}
