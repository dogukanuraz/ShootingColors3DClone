using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isStarted;

    private void Awake()
    {
        isStarted = false;
    }



    public void NextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene +1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentScene + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
