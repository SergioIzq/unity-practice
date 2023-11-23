using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    CharacterController cc;
    Vector3 moveTo, move;
    public float speed = 5F, laneSize = 3F, gravity = 20F,jumpForce = 70F;
    int actualLane = 0;
    
    void Start()
    {
        cc = GetComponent <CharacterController>(); 
    }

    void Update()
    {
        //Capturo los inputs
        if (Input.GetKeyDown(KeyCode.LeftArrow) && actualLane != -1) //Si pulso flecha izquierda
        {
            //calculo el movimiento y guardo en moveTo
            moveTo += Vector3.left * laneSize;
            actualLane--;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && actualLane != 1)
        {
            //calculo el movimiento y guardo en moveTo
            moveTo += Vector3.right * laneSize;
            actualLane++;
        }

        if (Input.GetKeyDown(KeyCode.Space) && cc.isGrounded) 
        {
            move.y = jumpForce;
        }

        move.x = (moveTo - transform.position).x * speed;

        if (!cc.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                move.y = -jumpForce;
            }
            else
            {
                move.y -= gravity * Time.deltaTime;
            }
        }

        cc.Move(move * Time.deltaTime);
    }
}
