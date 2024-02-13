using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < GameplayManager.instance.hints.Length; i++)
            {
                GameplayManager.instance.hints[i] = false;
            }
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
