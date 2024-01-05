using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void NextScene(string name_scene)
    {
        SceneManager.LoadScene(name_scene);
    }

    public void ChangeSceneGeneral(string name_scene)
    {
        Variables_Game.instance.mode_game=name_scene;
    }

    public void NextSceneGeneral()
    {
        
        SceneManager.LoadScene(Variables_Game.instance.mode_game);
    }
}
