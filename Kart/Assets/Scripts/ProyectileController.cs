using UnityEngine;
using UnityEngine.SceneManagement;

public class ProyectilController : MonoBehaviour
{
    public float velocidadReducida = 5F, duracionRalentizacion = 3F;

    void OnCollisionEnter(Collision collision)
    {
        PlayerController jugador = collision.gameObject.GetComponent<PlayerController>();

        if (jugador != null)
        {
            // Guardar la velocidad actual del jugador antes de reducirla
            float velocidadActual = jugador.acc;

            // Reducir la velocidad del jugador
            jugador.ReducirVelocidad(velocidadReducida);            

            // Destruir el proyectil al tocar al jugador
            Destroy(gameObject);

            // Iniciar el tiempo de ralentización
            jugador.IniciarTiempoRalentizacion(velocidadActual, duracionRalentizacion);
        }
    }
}
