using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_Game : MonoBehaviour
{

    public static Variables_Game instance;
    public int opcion_camera=1;
    public int current_score=0;
    public int combo_in_score=-1;
    public List<ObjectData> questions_by_theme;
    //public string themeSelected="";
    public ObjectTheme selectedTheme;


    public GameObject player;

    public AudioClip music;
    private AudioSource audioSource;
    public string state_music="unmute";

    public string difficulty="Easy";
    public int cantQuestions=1;

    //GAME: WAIT, START, END
    //public bool endGame=false;
    public string status="Wait";

    //MODIFICATE THEME
    public int changeFileThemes=1;

    //Player
    public string player_model="BÚHO";
    //Left - Right //Player
    public int player_direction=-1;

    //Speed
    public string increment_speed="x1.00";
    


    private void Awake(){
        if(instance==null){
            instance=this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            if(instance!=this){
                Destroy(gameObject);
            }
        }
    }
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = music;
        audioSource.loop = true; 
        audioSource.Play();   
    }

    public void ToggleMute()
    {
        audioSource.mute = !audioSource.mute;
    }

    void Update()
    {
 
    }

    public void ChangeMusic(){
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = music;
        audioSource.loop = true; 
        audioSource.Play();   
    }

    

}