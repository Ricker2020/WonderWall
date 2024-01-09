using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewDifficultySelected : MonoBehaviour
{
    public List<Button> listButton = new List<Button>();
    //public bool update;
    public Color colorButtonSelect;
    public Color colorTextSelect;
    public Color colorButtonUnselect;
    public Color colorTextUnselect;
    Image buttonImage;
    Text buttonText;
    string difficulty_text="";

    void Start()
    {

    }
  
    void Update(){
        

        if(difficulty_text!=Variables_Game.instance.difficulty){
            difficulty_text=Variables_Game.instance.difficulty;
            seteoColor();
            switch(difficulty_text){
                case "Easy":
                    buttonImage = listButton[0].GetComponent<Image>();
                    buttonImage.color = colorButtonSelect;
                    buttonText = listButton[0].GetComponentInChildren<Text>();
                    buttonText.color = colorTextSelect;
                    break;
                case "Medium":
                    buttonImage = listButton[1].GetComponent<Image>();
                    buttonImage.color = colorButtonSelect;
                    buttonText = listButton[1].GetComponentInChildren<Text>();
                    buttonText.color = colorTextSelect;
                    break;
                case "Hard":
                    buttonImage = listButton[2].GetComponent<Image>();
                    buttonImage.color = colorButtonSelect;
                    buttonText = listButton[2].GetComponentInChildren<Text>();
                    buttonText.color = colorTextSelect;
                    break;
            } 
        }
        
    }

    void seteoColor(){
        Image button_Image;
        Text button_Text;

        foreach (Button button in listButton){
            button_Image = button.GetComponent<Image>();
            button_Image.color = colorButtonUnselect;
            button_Text = button.GetComponentInChildren<Text>();
            button_Text.color = colorTextUnselect;
        }
    }

    
}
