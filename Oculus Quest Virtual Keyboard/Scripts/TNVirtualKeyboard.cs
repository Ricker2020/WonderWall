using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TNVirtualKeyboard : MonoBehaviour
{
	
	public static TNVirtualKeyboard instance;
	
	public string words = "";
	
	public GameObject vkCanvas;
	
	public InputField targetText;
	
	public Text debugText;
	

    void Start()
    {
        instance = this;
		HideVirtualKeyboard();
		
    }

    void Update()
    {
        
    }
	
	public void KeyPress(string k){
		words = targetText.text+k;
		//words += k;
		targetText.text = words;	
		debugText.text = words;
	}
	
	public void Del(){
		words = targetText.text;
		if(words.Length>0){
			words = words.Remove(words.Length - 1, 1);
			targetText.text = words;	
			debugText.text = words;
		}
	}
	
	public void ShowVirtualKeyboard(){
		vkCanvas.SetActive(true);
	}
	
	public void HideVirtualKeyboard(){
		vkCanvas.SetActive(false);
	}
}
