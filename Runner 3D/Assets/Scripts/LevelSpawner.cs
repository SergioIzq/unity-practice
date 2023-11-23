using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{

    public GameObject[] levels; 
    public GameObject lastLevelSpawned, level;//Array en un futuro
    public void Spawn()//lo llamará el delete level
    {
        int r = Random.Range(0, levels.Length-1);
        //Instanciar nuevo nivel en el spawnPoint del último nivel instanciado
        lastLevelSpawned = Instantiate(levels[r], lastLevelSpawned.GetComponent<LevelController>().getSpawnPointPosition(), Quaternion.identity);

    }

}
