using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{    
    public GameObject Proyectile; 
    public float proyectilSpeed = 5F, tiempoDeEsperaLanzamiento = 5F, rotationSpeed = 5F, acc, dcc, altura = 0.44F;
    private bool canWin = false, ralentizando = false, cooldownLanzamientoActivo = false;
    float horizontal, vertical, speed;
    Vector3 rot;
    Rigidbody rb;
    public int playerNumber;
    private int loaps = 0;
    private float tiempoRalentizacionInicio, tiempoRalentizacionDuracion, accOriginal, tiempoCooldownInicio;    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetHorizontalInput();
        GetVerticalInput();
        // Restringir el lanzamiento de proyectiles si no ha pasado el tiempo de espera
        if (!cooldownLanzamientoActivo && ((playerNumber == 1 && Input.GetKeyDown(KeyCode.G)) || (playerNumber == 2 && Input.GetKeyDown(KeyCode.Mouse0))))
        {
            LanzarProyectil();
            ActivarCooldownLanzamiento();
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
        if (ralentizando && Time.time - tiempoRalentizacionInicio >= tiempoRalentizacionDuracion)
        {
            RestaurarVelocidad(accOriginal);
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
        if (cooldownLanzamientoActivo && Time.time - tiempoCooldownInicio >= tiempoDeEsperaLanzamiento)
        {
            cooldownLanzamientoActivo = false;
        }
    }

    void ActivarCooldownLanzamiento()
    {
        // Desactivar la posibilidad de lanzar proyectiles durante el tiempo de espera
        cooldownLanzamientoActivo = true;
        tiempoCooldownInicio = Time.time;
    }

    private void GetVerticalInput()
    {
        speed = 0;
        vertical = Input.GetAxis("Vertical" + playerNumber);
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
        horizontal = Input.GetAxis("Horizontal" + playerNumber);
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

        // Crear una instancia del proyectil
        GameObject proyectil = Instantiate(Proyectile, new Vector3(transform.position.x, altura, transform.position.z), transform.rotation);

        // Obtener el componente Rigidbody del proyectil
        Rigidbody proyectilRb = proyectil.GetComponent<Rigidbody>();

        if (proyectilRb != null)
        {
            // Asignar velocidad al proyectil
            proyectilRb.velocity = transform.forward * proyectilSpeed;
        }

        Destroy(proyectil, 2);
    }

    public void IniciarTiempoRalentizacion(float velocidadOriginal, float duracion)
    {
        tiempoRalentizacionInicio = Time.time;
        tiempoRalentizacionDuracion = duracion;
        accOriginal = velocidadOriginal;
        ralentizando = true;
    }
    public void ReducirVelocidad(float factorReduccion)
    {
        // Reducir la velocidad del jugador
        acc /= factorReduccion;
        accOriginal = acc;
        ralentizando = true;
        tiempoRalentizacionInicio = Time.time;
        tiempoRalentizacionDuracion = tiempoDeEsperaLanzamiento;

    }

    public void RestaurarVelocidad(float velocidadOriginal)
    {
        // Restablecer la velocidad original del jugador
        acc = velocidadOriginal;
        ralentizando = false; 
    }
}
