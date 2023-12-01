using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyPlayer : MonoBehaviour
{
    public void SelectDifficulty(string difficulty){
        Variables_Game.instance.difficulty=difficulty;
    }
}
