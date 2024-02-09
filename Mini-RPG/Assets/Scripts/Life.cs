using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController playerController = collision.GetComponent<PlayerController>();
            Destroy(gameObject);
            if (playerController.lifes >= 3)
            {
                Debug.Log("Has llegado al máximo de vidas." + playerController.lifes);
            }
            else
            {
                playerController.lifes++;
                Debug.Log("¡Has ganado una vida! Ahora tienes " + playerController.lifes + " vidas.");
            }
            Debug.Log(playerController.lifes);
        }
    }
}
