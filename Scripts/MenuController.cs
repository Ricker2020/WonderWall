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
}
