using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetValuesAprendizaje : MonoBehaviour
{

    public void FunctionReset()
    {
        //RESET VALUES
        Variables_Game.instance.current_score = 0;
        Variables_Game.instance.combo_in_score = -1;
        Variables_Game.instance.status = "Wait";
    }


}
