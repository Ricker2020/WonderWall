using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseInGame : MonoBehaviour
{
    
    public Sprite pause;
    public Sprite play;
    public GameObject pauseMenu;

    Image image;
    bool isPlay=true;

    void Start()
    {
        image= GetComponent<Image>();
        pause=image.sprite;
    }
    
    public void changeState(){
        isPlay=!isPlay;

        if(isPlay){
            image.sprite = pause;
            Time.timeScale = 1.0f;
            pauseMenu.SetActive(false); 
        }else{
            image.sprite = play;
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);

        }
    }

}
