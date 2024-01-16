using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeColorCube : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Material materialHover;
    private Material originalMaterial;

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            originalMaterial = renderer.material;
        }
      
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        CambiarMaterialHover(true);
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        CambiarMaterialHover(false);
    }

    void CambiarMaterialHover(bool hover)
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = hover ? materialHover : originalMaterial;
        }
    }
}

