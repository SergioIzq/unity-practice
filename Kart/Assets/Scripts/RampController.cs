using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class RampController : MonoBehaviour
{
    public float fuerzaEmpuje = 500f;
    Rigidbody jugadorRb;
    Vector3 direccionEmpuje;
    private void OnTriggerEnter(Collider other)
    {
        jugadorRb = other.GetComponent<Rigidbody>();
        direccionEmpuje = transform.forward;
        jugadorRb.AddForce(direccionEmpuje * fuerzaEmpuje);

    }
}


