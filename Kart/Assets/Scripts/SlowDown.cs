using UnityEngine;

public class SlowDown : MonoBehaviour
{
    public float factorRalentizar = 0.8F; 
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
