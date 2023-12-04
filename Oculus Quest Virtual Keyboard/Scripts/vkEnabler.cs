using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vkEnabler : MonoBehaviour
{
    void Start()
    {
        //ShowVirtualKeyboard();
    }


    void Update()
    {
        
    }
	
	public void ShowVirtualKeyboard(){
		TNVirtualKeyboard.instance.ShowVirtualKeyboard();
		TNVirtualKeyboard.instance.targetText = gameObject.GetComponent<InputField>();
	}
}
