using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float horizontal, vertical, speed;
    Vector3 rot;
    Rigidbody rb;
    public int playerNumber;
    public float rotationSpeed = 5f, acc, dcc;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        GetHorizontalInput();
        GetVerticalInput();
    }

    void FixedUpdate()
    {
        if (Math.Abs(speed) > 0) //Así funciona para eje positivo y negativo
        {
            rb.AddForce(speed * transform.forward);

            if (speed > 0)
            {
                rb.AddTorque(rot);
            }
            else
            {
                rb.AddTorque(-rot);
            }
        }
    }

    private void GetVerticalInput()
    {
        speed = 0;
        vertical = Input.GetAxis("Vertical"+playerNumber);
        if (vertical > 0)
        {
            speed = acc * vertical;
        }
        else if (vertical < 0)
        {
            speed = dcc * vertical;
        }
    }

    private void GetHorizontalInput()
    {
        horizontal = Input.GetAxis("Horizontal"+playerNumber);
        float newRot = horizontal * rotationSpeed;
        rot = new Vector3(0f, newRot, 0f);
    }


}
