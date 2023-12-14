using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivateEnemy : MonoBehaviour
{
    private float timePassed = 0f;
    private bool isActive = true;
    public GameObject enemigo;

    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed >= 1f)
        {
            isActive = !isActive;
            enemigo.SetActive(isActive);
            timePassed = 0f;
        }
    }
    
}
