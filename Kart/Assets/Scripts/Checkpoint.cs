using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    PlayerController pj;

    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(pj != null) { 
            pj = other.GetComponent<PlayerController>();
            pj.setCanWin(true);

            Debug.Log("Puede ganar el jugador "+ pj.playerNumber + ": " + pj.getCanWin());
        }

    }
}
