using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{ 

    public int idHint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameplayManager.instance.setHint(idHint);
            Destroy(gameObject);
        }
    }
}
