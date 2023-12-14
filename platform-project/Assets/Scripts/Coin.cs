using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerController playerController = other.GetComponent<PlayerController>();
        playerController.coins++;
        Destroy(gameObject);
        if (playerController.coins == 3 || playerController.coins == 6 || playerController.coins == 9)
        {
            playerController.lifes++;
            Debug.Log("¡Has ganado una vida! Ahora tienes " + playerController.lifes + " vidas.");
        }
    }    
}
