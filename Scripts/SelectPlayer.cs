using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPlayer : MonoBehaviour
{
    
    public void GetPlayer(Text name_model){
        Variables_Game.instance.player_model=name_model.text;
    }
}
