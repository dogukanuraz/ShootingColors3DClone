using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    int currentScene;

    #region 
    public static LoadManager Instance { get; private set; } = null;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    #endregion

   
    

    private void Update()
    {
        LoadScene();
        MuteAudio();
    }

    void LoadScene()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 0)
        {
            if (PlayerPrefs.HasKey("currentScene"))
            {
                if (PlayerPrefs.GetInt("currentScene") ==0)
                {
                    SceneManager.LoadScene(currentScene + 1);
                }
                else if (PlayerPrefs.GetInt("currentScene") >= 6)
                {
                    SceneManager.LoadScene(1);
                }
                else
                {
                    SceneManager.LoadScene(PlayerPrefs.GetInt("currentScene"));
                }
                
            }
            else
            {
                SceneManager.LoadScene(currentScene + 1);
                
            }
        }
        else
        {
            PlayerPrefs.SetInt("currentScene", currentScene);
        }
    }

    void MuteAudio()
    {
        if (PlayerPrefs.HasKey("muteControl"))
        {
            if (PlayerPrefs.GetInt("muteControl") == 1)
            {
                SoundManager.isMute = true;
            }
            else
            {
                SoundManager.isMute = false;
            }
        }
        else
        {
            PlayerPrefs.SetInt("muteControl", 1);
        }        
    }


}
