using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    private float sizeMultiplier = 2.0f;
    private PlayerController playerController;
    private bool hasAppliedImmunity = false;
    private bool hasAppliedSizeIncrease = false;
    private float immunityStartTime;
    private float sizeIncreaseStartTime;
    private Material originalPlayerMaterial; 

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        CheckPowerUpDuration();
    }

    private void CheckPowerUpDuration()
    {
        if (hasAppliedImmunity)
        {
            if (Time.time - immunityStartTime > 2f)
            {
                RevertImmunity();
            }
        }

        if (hasAppliedSizeIncrease)
        {
            if (Time.time - sizeIncreaseStartTime > 2f)
            {
                RevertSizeIncrease();
            }
        }
    }

    public void ApplyImmunity(GameObject player, float duration)
    {
        if (!hasAppliedImmunity)
        {
            Renderer playerRenderer = player.GetComponent<Renderer>();
            PlayerController playerController = player.GetComponent<PlayerController>();
            originalPlayerMaterial = new Material(playerRenderer.material); 
            playerRenderer.material.color = Color.magenta;

            if (!playerController.isInmortal)
            {
                playerController.EnableImmunity();
                hasAppliedImmunity = true;
                immunityStartTime = Time.time;
            }            
        }
    }

    public void ApplySizeIncrease(GameObject player, float duration)
    {
        if (!hasAppliedSizeIncrease)
        {
            if (Mathf.Approximately(player.transform.localScale.x, 1.0f))
            {
                player.transform.localScale *= sizeMultiplier;
                hasAppliedSizeIncrease = true;
                sizeIncreaseStartTime = Time.time;
            }
        }
    }

    private void RevertImmunity()
    {
        playerController.DisableImmunity();
        hasAppliedImmunity = false;

        Renderer playerRenderer = playerController.GetComponent<Renderer>();
       
        playerRenderer.material = originalPlayerMaterial;        
    }

    private void RevertSizeIncrease()
    {
        playerController.transform.localScale /= sizeMultiplier;
        hasAppliedSizeIncrease = false;
    }
}
