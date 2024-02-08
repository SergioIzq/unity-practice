using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f; // Velocidad de movimiento del jugador
    public int coins = 0;
    public int lifes = 3;
    public GameObject leftRect;
    public GameObject rightRect;
    // Método Update se llama una vez por cada frame
    void Update()
    {
        // Obtener las entradas del teclado para el movimiento
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        // Verificar si se presiona una tecla (por ejemplo, la tecla "Espacio")
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Mostrar los rectángulos
            leftRect.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            // Mostrar los rectángulos
            leftRect.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Mostrar los rectángulos
            rightRect.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            // Mostrar los rectángulos
            rightRect.SetActive(false);
        }
        // Movimiento horizontal
        if (Input.GetKey(KeyCode.A)) // Tecla A para moverse a la izquierda
        {
            moveHorizontal = -1f;
        }
        else if (Input.GetKey(KeyCode.D)) // Tecla D para moverse a la derecha
        {
            moveHorizontal = 1f;
        }

        // Movimiento vertical
        if (Input.GetKey(KeyCode.S)) // Tecla S para moverse hacia abajo
        {
            moveVertical = -1f;
        }
        else if (Input.GetKey(KeyCode.W)) // Tecla W para moverse hacia arriba
        {
            moveVertical = 1f;
        }

        // Calcular el vector de movimiento basado en las entradas del teclado
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f) * speed * Time.deltaTime;

        // Aplicar el movimiento al jugador
        transform.position += movement;
    }
}