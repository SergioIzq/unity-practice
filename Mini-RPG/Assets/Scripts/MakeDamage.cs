using UnityEngine;

public class MakeDamage : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            
            playerController.lifes--;

            Debug.Log("Te has chocado con un enemigo, te quedan " + playerController.lifes + " vida(s).");

            if (playerController.lifes == 0)
            {
                Debug.Log("Has perdido, pulsa R para volver a intentarlo.");
                Time.timeScale = 0;
            }            
        }
    }
}
