using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotarX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotationSpeed = 50f;


    

    void Update()
    {

            RotateObject();
    }

    void RotateObject()
    {
        // Rotar el objeto alrededor del eje Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
