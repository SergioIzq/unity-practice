using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Meta : MonoBehaviour
{
    PlayerController playerController;
    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (playerController.coins == 9)
        {
            Debug.Log("Has ganado el nivel!! Pulsa R para volver a jugarlo.");
            Time.timeScale = 0;
        }
        else
        {
            Debug.Log("Tienes que recoger todas las monedas para pasarte el nivel!!");
        }
    }
}
