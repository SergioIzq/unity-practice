using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyParent")) { 
                //Destruyo al enemigo que me ha dado
                Destroy(collision.gameObject);
        }
        if(collision.CompareTag("CoinParent")) {
            //Destruyo la moneda que me ha dado
            Destroy(collision.gameObject);
        }
    }
}
