using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicInGame : MonoBehaviour
{
    public List<AudioClip> clipsDeAudio = new List<AudioClip>();
    public Text name_music;
    public Button buttonLeft;
    public Button buttonRight;
    int count=0;
    int size_data=0;

    void Start(){
        //string names="";
        size_data=clipsDeAudio.Count;
        /*
        foreach (AudioClip clip in clipsDeAudio)
        {
            names+=clip.name;
        }*/
        name_music.text=clipsDeAudio[0].name;

        buttonLeft.onClick.AddListener(() => ChangeMusic(-1));
        buttonRight.onClick.AddListener(() => ChangeMusic(1));
        


    }

    void ChangeMusic(int direction)
    {
        if(direction==-1){
            if(count==0){
                count=size_data;
            }
            count-=1;
        }
        else{
            if(count==size_data-1){
                count=-1;
            }
            count+=1;
        }
        name_music.text=clipsDeAudio[count].name;
        Variables_Game.instance.music=clipsDeAudio[count];
        Variables_Game.instance.ChangeMusic();
    }
}
