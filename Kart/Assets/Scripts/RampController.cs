using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class RampController : MonoBehaviour
{
    public float fuerzaEmpuje = 500f;
    Rigidbody jugadorRb;
    private void OnTriggerEnter(Collider other)
    {
        jugadorRb = other.GetComponent<Rigidbody>();

        if ( jugadorRb != null)
        {
            jugadorRb.AddForce(transform.forward * fuerzaEmpuje);
        }
    }
}


