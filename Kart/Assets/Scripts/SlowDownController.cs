using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownController : MonoBehaviour
{
    public float factorRalentizar = 0.5f; 
    Rigidbody pjRb;
    private void OnTriggerStay(Collider other)
    {
        pjRb = other.GetComponent<Rigidbody>();
        // Ralentizar la velocidad
        pjRb.velocity *= factorRalentizar;
        
    }
}
