using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFinalTutorial : MonoBehaviour
{
    public bool final=false;
    public GameObject nextStep;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -3.0 && !final)
        {
            final=true;
            nextStep.gameObject.SetActive(true);
            gameObject.SetActive(false);
            
        }
        
    }
}
