using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiversionMovementHelice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 100f;
    public float direction=1.0f;
    void Update()
    {
        transform.Rotate(Vector3.right   * speed * Time.deltaTime);
    }
}
