using UnityEngine;

public class ProyectilController : MonoBehaviour
{
    public float velocidadReducida = 5f;

    void OnCollisionEnter(Collision collision)
    {
        // Verificar si el proyectil ha colisionado con un jugador
        PlayerController jugador = collision.gameObject.GetComponent<PlayerController>();

        if (jugador != null)
        {
            // Obtener el componente Rigidbody del jugador
            Rigidbody jugadorRb = jugador.GetComponent<Rigidbody>();

            if (jugadorRb != null)
            {
                // Reducir la velocidad del jugador
                jugadorRb.velocity /= velocidadReducida;

                // Destruir el proyectil al tocar al jugador
                Destroy(gameObject);
            }
        }
    }
}
