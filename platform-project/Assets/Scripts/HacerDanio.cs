using UnityEngine;

public class HacerDanio : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if (!playerController.isInmortal)
            {
                playerController.lifes--;

                Debug.Log("Te has chocado con un enemigo, te quedan " + playerController.lifes + " vida(s).");

                if (playerController.lifes == 0)
                {
                    Debug.Log("Has perdido, pulsa R para volver a intentarlo.");
                    Time.timeScale = 0;
                }
            }
            else
            {
                Debug.Log("Te has salvado del daño gracias al power-up de invencibilidad!!!.");
            }
        }
    }
}
