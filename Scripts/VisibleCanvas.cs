using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Desactivar el canvas al inicio del juego
    //myCanvas.SetActive(false);
        if(Variables_Game.instance.opcion_camera==0){
           gameObject.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
