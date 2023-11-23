using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Controlar el tiempo

    float timePassed;
    public float timeToSpawn = 2F;

    // Spawnear

    public GameObject[] enemies;

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > timeToSpawn)
        {
            // Spawn
            int r = Random.Range(0, enemies.Length);
            Instantiate(enemies[r], transform.position, Quaternion.identity);
            timePassed = 0;
        }


    }
}
