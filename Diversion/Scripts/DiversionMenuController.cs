using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiversionMenuController : MonoBehaviour
{

    public void changeGameDiversion(string selectJuego){
        Variables_Diversion.instance.tipo_juego = selectJuego;
    }

    public void NextScene(){
        SceneManager.LoadScene(Variables_Diversion.instance.tipo_juego);
    }
    
    public void NextSceneByName(string scene){
        SceneManager.LoadScene(scene);
    }
}
