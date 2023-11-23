using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Transform spawnPoint;
    public float speed = 5F;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }

    public Vector3 getSpawnPointPosition()
    {
        return spawnPoint.position;
    }
}
