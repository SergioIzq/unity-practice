using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayManager : MonoBehaviour
{
    public static GamePlayManager instance;


    private void Awake()
    {
        // Aseguramos que solo haya una instancia del Singleton
        if (instance != null)
        {
            instance = this;

        }
        else
        {
            Destroy(instance);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeScene(int number)
    {
        SceneManager.LoadScene(number);
    }
}
