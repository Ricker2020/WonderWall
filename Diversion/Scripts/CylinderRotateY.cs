using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotateY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

 public float rotationSpeed = 210f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Rotar el objeto alrededor de su eje Y centrado en sí mismo
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
