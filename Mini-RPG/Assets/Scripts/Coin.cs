using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            playerController.coins++;
            Destroy(gameObject);
            Debug.Log(playerController.lifes);
            if (playerController.lifes >= 3)
            {
                Debug.Log("Has llegado al máximo de vidas." + playerController.lifes);
            }
            else
            {
                playerController.lifes++;
                Debug.Log("¡Has ganado una vida! Ahora tienes " + playerController.lifes + " vidas.");
            }
        }
    }    
}
