using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiversionMovementHelice2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float speed = 100f;
    float direction=1.0f;
    void Update()
    {
        transform.Rotate(Vector3.forward   * speed * Time.deltaTime);
        
    }
}
