using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HighlightedText : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler,IPointerClickHandler
{
    public Text buttonText;
    public Color highlightedColor;
    public Color originalColor;
/*
    private Button button;
    private Color buttonColor;
    private Color hexColor=HexToColor("174F1E");*/

    private void Start()
    {
        //button = GetComponent<Button>(); // Obtén el componente Button del botón
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.color = highlightedColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.color = originalColor;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        buttonText.color = originalColor;
    }

}
