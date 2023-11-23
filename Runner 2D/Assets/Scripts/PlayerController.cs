using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int lifes = 3;
    Vector3 moveTo;
    public float movement = 1F, limits = 3F,speed=20F;
    int coin = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y<limits)
        {
            //Guardar la nueva posición
            moveTo = new Vector3(0, transform.position.y + movement, 0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -limits)
        {
            moveTo = new Vector3(0, transform.position.y - movement, 0);
        }

        transform.position = Vector2.MoveTowards(transform.position,moveTo,speed*Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")) {
            lifes--;
            Debug.Log("Has chocado te quedan " + lifes + " vidas");
            if (lifes <= 0)
            {
                Time.timeScale = 0; // Pausar el juego
            }
        }
        if (collision.CompareTag("Coin")){            
            coin++;
            Destroy(collision.gameObject);
            if (coin > 10)
            {
                coin = 0;
                lifes++;
                Debug.Log("Has conseguido una vida");

            }
        }
    }



}
