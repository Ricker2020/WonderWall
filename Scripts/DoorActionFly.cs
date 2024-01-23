using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DoorActionFly : MonoBehaviour
{
    public Text question;
    public Text answer1;
    public Text answer2;
    public Text feedback;
    public Image background_feedback;
    // Accede al componente Image
    Image image;

    Color goodColor = new Color32(35, 89, 16, 212);
    Color badColor=new Color32(195, 35, 35, 212);

    public string text_question;
    public string text_answer1;
    public string text_answer2;
    public int position_correct;


    //public GameObject player;
    public GameObject door;
    GameObject player;
    bool once_selected=false;
    string text_feedback;

    //DIFFICULTY
    public float speed = 0;

    //string colorHexadecimal = "333";


    //Color del Texto
    string[] partes;  //0-> texto; 1-> color
    //string colorAux;
    Color colorTexto;

    void Start()
    {
        

        player=Variables_Game.instance.player;

        partes = text_question.Split(';');
        if(partes.Length >1){
            colorTexto = HexToColor(partes[1]);
            question.color= colorTexto;
        }
        question.text=partes[0];

        partes = text_answer1.Split(';');
        if(partes.Length >1){
            colorTexto = HexToColor(partes[1]);
            answer1.color= colorTexto;
        }
        answer1.text=partes[0];

        partes = text_answer2.Split(';');
        if(partes.Length >1){
            colorTexto = HexToColor(partes[1]);
            answer2.color= colorTexto;
        }
        answer2.text=partes[0];

/*
        Vector3 escala = new Vector3(4f, 4f, 4f);
        if(Variables_Game.instance.selectedTheme.title=="reconoce"){
            answer1.rectTransform.localScale = escala;
            answer2.rectTransform.localScale  = escala;
        }
*/
        if(Variables_Game.instance.selectedTheme.title=="reconoce"){
            answer1.fontSize  = 800;
            answer2.fontSize   = 800;
        }

        image = background_feedback.GetComponent<Image>();
        //Variables_Game.instance.current_score+=1;      
    }

    void Update()
    {
        transform.position += -transform.forward * speed * Time.deltaTime;

        if (transform.position.z < -10.0)
        {
            Destroy (gameObject);
        }

        //RANGO DE PREGUNTA
        if (transform.position.z < 0 && once_selected==false)
        {
            once_selected=true;
            //Si ambas son iguales
            if(text_answer1==text_answer2){
                    Variables_Game.instance.combo_in_score+=1;
                    int score_aux=100 + (50*Variables_Game.instance.combo_in_score);
                    Variables_Game.instance.current_score+=score_aux;
                    text_feedback="Genial!!! La respuesta que elegiste es correcta +"+score_aux;
                    image.color = goodColor;
            }else{
                //Significa que escoge la answer1
                if(player.transform.position.y>0 ){
                    if(position_correct==1){
                        Variables_Game.instance.combo_in_score+=1;
                        int score_aux=100 + (50*Variables_Game.instance.combo_in_score);
                        Variables_Game.instance.current_score+=score_aux;
                        text_feedback="Genial!!! La respuesta que elegiste es correcta +"+score_aux;
                        image.color = goodColor;
                    }
                    else{
                        Variables_Game.instance.combo_in_score=-1;
                        text_feedback="La respuesta que elegiste no es correcta. La respuesta era: "+text_answer2;
                        image.color = badColor;
                    }

                }
                //Significa que escoge la answer2
                else{
                    if(position_correct==2){
                        Variables_Game.instance.combo_in_score+=1;
                        int score_aux=100 + (50*Variables_Game.instance.combo_in_score);
                        Variables_Game.instance.current_score+=score_aux;
                        text_feedback="Genial!!! La respuesta que elegiste es correcta +"+score_aux;
                        image.color = goodColor;
                    }else{
                        Variables_Game.instance.combo_in_score=-1;
                        text_feedback="La respuesta que elegiste no es correcta. La respuesta era: "+text_answer1;
                        image.color = badColor;
                    }
                }

            }



            feedback.transform.parent.GetComponent<Canvas>().enabled = true;
            feedback.text=text_feedback;

            door.SetActive(false);

            

        }

        
    }



    private Color HexToColor(string hex){
        Color color = new Color();

        // Eliminar el caracter "#" si está presente en el valor hexadecimal
        if (hex.StartsWith("#"))
            hex = hex.Substring(1);

        // Convertir los valores hexadecimales a valores decimales y asignar al objeto Color
        color.r = System.Convert.ToInt32(hex.Substring(0, 2), 16) / 255f;
        color.g = System.Convert.ToInt32(hex.Substring(2, 2), 16) / 255f;
        color.b = System.Convert.ToInt32(hex.Substring(4, 2), 16) / 255f;
        color.a = 1f; // Establecer la transparencia (alpha) a 1
        return color;
    }


}
