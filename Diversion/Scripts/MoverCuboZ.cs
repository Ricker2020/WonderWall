using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCuboZ : MonoBehaviour
{
    public float zMinLimit = 260f; // Límite inferior en el eje Z
    public float zMaxLimit = 269f; // Límite superior en el eje Z
    public float movementSpeed = 1f; // Velocidad de movimiento en unidades por segundo

    private void Update()
    {
        // Calcular el nuevo valor en el eje Z usando la función Mathf.PingPong
        float newZ = Mathf.PingPong(Time.time * movementSpeed, zMaxLimit - zMinLimit) + zMinLimit;

        // Actualizar la posición del objeto en el eje Z
        Vector3 newPosition = transform.position;
        newPosition.z = newZ;
        transform.position = newPosition;
    }
}
