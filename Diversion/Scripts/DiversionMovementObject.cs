using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiversionMovementObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 5f; // Velocidad del movimiento en el eje X
    public float rango1 = -5f; // Límite izquierdo del rango
    public float rango2 = 5f; // Límite derecho del rango
    private int direction = 1; // Dirección del movimiento (1 para derecha, -1 para izquierda)

    void Update()
    {
        // Obtener la posición actual del objeto
        Vector3 currentPosition = transform.position;

        // Verificar si el objeto ha alcanzado alguno de los límites y cambiar la dirección
        if (currentPosition.x > rango2 || currentPosition.x < rango1)
        {
            direction *= -1;
        }

        // Calcular la nueva posición en el eje X con la velocidad y el tiempo transcurrido
        float newX = currentPosition.x + direction * speed * Time.deltaTime;

        // Crear una nueva posición con la nueva coordenada X y las coordenadas actuales en Y y Z
        Vector3 newPosition = new Vector3(newX, currentPosition.y, currentPosition.z);

        // Actualizar la posición del objeto
        transform.position = newPosition;
    }
}
