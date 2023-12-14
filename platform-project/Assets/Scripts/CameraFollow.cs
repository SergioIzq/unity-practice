using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 distancia = new Vector3(0, 10, -20);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + distancia;
    }
}