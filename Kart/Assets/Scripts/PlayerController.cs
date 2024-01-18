using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float offsetZ = 1f; // Ajusta según sea necesario

    public GameObject Proyectile; // Asegúrate de asignar un GameObject en el Inspector
    public float proyectilSpeed = 5F;
    private bool canWin = false;
    float horizontal, vertical, speed;
    Vector3 rot;
    Rigidbody rb;
    public int playerNumber;
    public float rotationSpeed = 5f, acc, dcc;
    private int loaps = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetHorizontalInput();
        GetVerticalInput();

        if (playerNumber == 1)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                LanzarProyectil();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                LanzarProyectil();
            }
        }

        if (loaps == 3)
        {
            Debug.Log("Ha ganado el jugador " + playerNumber + ". Pulsa R para volver a intentar.");
            Time.timeScale = 0F;

            if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
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

    public void setLoaps(int loap)
    {
        this.loaps = loap;
    }

    public int getLoaps()
    {
        return this.loaps;
    }

    public bool getCanWin()
    {
        return canWin;
    }

    public void setCanWin(bool canWin)
    {
        this.canWin = canWin;
    }

    void LanzarProyectil()
    {
        float alturaDeseada = 1f;

        // Crear una instancia del proyectil
        GameObject proyectil = Instantiate(Proyectile, new Vector3(transform.position.x, alturaDeseada, transform.position.z), transform.rotation);

        // Obtener el componente Rigidbody del proyectil
        Rigidbody proyectilRb = proyectil.GetComponent<Rigidbody>();

        if (proyectilRb != null)
        {
            // Asignar velocidad al proyectil
            proyectilRb.velocity = transform.forward * proyectilSpeed;
        }
        Destroy(proyectil, 2);
    }

}
