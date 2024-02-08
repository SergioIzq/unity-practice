using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swords : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto con el que chocamos es un enemigo
        if (other.CompareTag("Enemy"))
        {
            // Destruir al enemigo
            Destroy(other.gameObject);
        }
    }
}
