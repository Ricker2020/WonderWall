using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiversionCubosFinales : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float leftLimit = -5f; // Límite izquierdo del movimiento en el eje X
    public float rightLimit = 5f; // Límite derecho del movimiento en el eje X
    public float speed = 2f; // Velocidad del movimiento en el eje X

    private int direction = -1; // Dirección del movimiento (-1 para izquierda, 1 para derecha)

    void Update()
    {
        // Obtener la posición actual del objeto
        Vector3 currentPosition = transform.position;

        // Verificar si el objeto ha alcanzado alguno de los límites y cambiar la dirección
        if (currentPosition.x <= leftLimit)
        {
            direction = 1;
        }
        else if (currentPosition.x >= rightLimit)
        {
            direction = -1;
        }

        // Calcular el nuevo valor en el eje X con la velocidad y el tiempo transcurrido
        float newX = currentPosition.x + direction * speed * Time.deltaTime;

        // Limitar el valor del eje X dentro del rango establecido
        newX = Mathf.Clamp(newX, leftLimit, rightLimit);

        // Crear una nueva posición con el nuevo valor en el eje X y las coordenadas actuales en Y y Z
        Vector3 newPosition = new Vector3(newX, currentPosition.y, currentPosition.z);

        // Actualizar la posición del objeto
        transform.position = newPosition;
    }
}

