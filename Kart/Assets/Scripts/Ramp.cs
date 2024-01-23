using UnityEngine;
public class Ramp : MonoBehaviour
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


