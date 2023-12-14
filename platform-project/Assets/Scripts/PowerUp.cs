using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float effectDuration = 2.0f;

    private GameObject affectedPlayer;
    private PowerUpManager powerUpManager;

    private void OnTriggerEnter(Collider other)
    {
        powerUpManager = FindObjectOfType<PowerUpManager>();
        if (other.CompareTag("Player"))
        {
            affectedPlayer = other.gameObject;

            int randomEffect = Random.Range(0, 2);

            if (randomEffect == 0)
            {
                powerUpManager.ApplyImmunity(affectedPlayer, effectDuration);
            }
            else
            {
                powerUpManager.ApplySizeIncrease(affectedPlayer, effectDuration);
            }

            Destroy(gameObject);
        }
    }
}
