using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float fallThreshold = -10F; // Valor de umbral para la caída

    void Update()
    {
        GameObject playerObject = GameObject.Find("Player"); 

            PlayerController playerController = playerObject.GetComponent<PlayerController>();

            if (playerController.transform.position.y < fallThreshold)
            {
                // El jugador se ha caído del mapa, pausa el juego
                Debug.Log("Te has caído del mapa. Juego pausado. Pulsa R para volver a intentar.");
                Time.timeScale = 0F;

                
            }
        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    }
}