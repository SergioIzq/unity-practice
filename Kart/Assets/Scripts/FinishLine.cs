
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    PlayerController pj;
    private void OnTriggerEnter(Collider other)
    {
        pj = other.GetComponent<PlayerController>();

        if (pj != null)
        {

            if (pj.getCanWin())
            {
                pj.setLoaps(pj.getLoaps() + 1);
                pj.setCanWin(!pj.getCanWin());
            }

            Debug.Log("Puede ganar el jugador " + pj.playerNumber + ": " + pj.getCanWin());
            Debug.Log("Vueltas del jugador " + pj.playerNumber + ": " + pj.getLoaps());
        }
    }

}

