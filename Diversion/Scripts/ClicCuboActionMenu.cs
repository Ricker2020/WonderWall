using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClicCuboActionMenu : MonoBehaviour, IPointerClickHandler 
{
   
    public GameObject objeto1;
    public GameObject objeto2;
    public string selectJuego;

    public void OnPointerClick(PointerEventData eventData)
    {
        Variables_Diversion.instance.tipo_juego = selectJuego;
        objeto1.SetActive(true);
        objeto2.SetActive(false);

    }

}
