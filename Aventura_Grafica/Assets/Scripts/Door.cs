using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int sceneNum;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Hacer el compare tag para que solo se trigereé cuando sea el player el que entre

        GamePlayManager.instance.ChangeScene(sceneNum);
    }
}
