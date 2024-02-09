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
            Debug.Log("Has coleccionado " + playerController.coins + " moneda(s)!!.");
        }
    }    
}
