using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_Diversion : MonoBehaviour
{

    public static Variables_Diversion instance;
    public int opcion_camera = 1;

    //JUEGOS SELECCIONADOS POR EL USUARIO
    public string tipo_juego = "";

    //CARRERA CONTRA EL TIEMPO
    public double puntaje = 0f;
    public double savedTime = 0f;


    public int vidas_carrera = 3;
    public bool eliminar_vidas = true;
    //public AudioClip coin; //musica de coin
    //private AudioSource audioCoin;



    //PISTAS
    public bool collision = false;
    public double attempts = 0f;
    public int monedas = 0;
    public bool coin1 = true;
    public bool coin2 = true;
    public bool coin3 = true;



    public GameObject player;

    public AudioClip music;
    private AudioSource audioSource;
    public string state_music = "unmute";

    //GAME: WAIT, START, END
    public string status = "Wait";

    //Player
    public string player_model = "BÚHO";
    //Left - Right //Player
    public int player_direction = -1;

    //Speed
    //public string increment_speed="x1.00";
    //Tutorial
    public int direction_arrow = 0;
    public int movement_tutor = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
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

    public void ChangeMusic()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = music;
        audioSource.loop = true;
        audioSource.Play();
    }

    /*
        public void CoinMusic(){

            audioSource = GetComponent<AudioSource>();
            audioSource.clip=coin;
            audioSource.Play();   
        }
    */


}
