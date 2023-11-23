using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Este m�todo se llama cuando otro collider entra en el �rea de trigger de este collider.
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto con el que entramos en contacto tiene la etiqueta "Jugador".
        if (other.CompareTag("Player"))
        {
            // Destruye esta moneda espec�fica.
            Destroy(gameObject);
        }
    }
}
