using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiversionSelectPlayer : MonoBehaviour
{
    public void GetPlayer(Text name_model){
        Variables_Diversion.instance.player_model=name_model.text;
    }
}
