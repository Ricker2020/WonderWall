using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCuboY : MonoBehaviour
{

    void Start()
    {
        
    }

    public float minY = -8f; // Límite inferior del rango en el eje Y
    public float maxY = -11.3f; // Límite superior del rango en el eje Y
    public float speed = 2f; // Velocidad del movimiento en el eje Y

    private int direction = 1; // Dirección del movimiento (1 para subir, -1 para bajar)

    void Update()
    {
        // Obtener la posición actual del objeto
        Vector3 currentPosition = transform.position;

        // Verificar si el objeto ha alcanzado alguno de los límites y cambiar la dirección
        if (currentPosition.y >= maxY)
        {
            direction = -1;
        }
        else if (currentPosition.y <= minY)
        {
            direction = 1;
        }

        // Calcular el nuevo valor en el eje Y con la velocidad y el tiempo transcurrido
        float newY = currentPosition.y + direction * speed * Time.deltaTime;

        // Limitar el valor del eje Y dentro del rango establecido
        newY = Mathf.Clamp(newY, minY, maxY);

        // Crear una nueva posición con las coordenadas actuales en X y Z, y el nuevo valor en el eje Y
        Vector3 newPosition = new Vector3(currentPosition.x, newY, currentPosition.z);

        // Actualizar la posición del objeto
        transform.position = newPosition;
    }
}
