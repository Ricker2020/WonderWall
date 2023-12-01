using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundInGameGeneral : MonoBehaviour
{

    Image image;
    public Sprite unmute;
    public Sprite mute;

    void Start(){
        image= GetComponent<Image>();
        unmute=image.sprite;
        changeImagen();
    }
     
    public void muteORunmute(){
        if(Variables_Game.instance.state_music=="unmute"){
            Variables_Game.instance.state_music="mute";
        }else{
            Variables_Game.instance.state_music="unmute";
        }
        changeImagen();
        Variables_Game.instance.ToggleMute();
    }

    public void changeImagen(){
        if(Variables_Game.instance.state_music=="unmute"){
            image.sprite = unmute;
        }else{
            image.sprite = mute;
        }

    }

   
}
