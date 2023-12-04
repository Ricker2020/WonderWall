using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLinkWeb : MonoBehaviour
{
    public void OpenLink(string enlace){
        Application.OpenURL(enlace);
    }
}
