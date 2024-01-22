using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownController : MonoBehaviour
{
    public float factorRalentizar = 0.5F; 
    Rigidbody pjRb;

    private void OnTriggerStay(Collider other)
    {
        pjRb = other.GetComponent<Rigidbody>();
        if (pjRb != null)
        {
            // Ralentizar la velocidad
            pjRb.velocity *= factorRalentizar;
        }
    }
}
