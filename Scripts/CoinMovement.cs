using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    float rotationSpeed = 100f;
    float speed = 1.0f;

    void Update()
    {
        //Vector3 translation = -transform.up * speed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(Vector3.forward * rotationSpeed * Time.deltaTime);
        transform.rotation *= rotation;
        //transform.Translate(translation, Space.Self);
    }
}
