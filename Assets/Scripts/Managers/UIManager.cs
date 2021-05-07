using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject inGameUI;
    public GameObject menuUI;
    public Text levelText;

    public Button mute;
    public Button demute;


    private void Start()
    {
        if (SoundManager.isMute)
        {
            demute.gameObject.SetActive(true);
            mute.gameObject.SetActive(false);
        }
        if (!SoundManager.isMute)
        {
            demute.gameObject.SetActive(false);
            mute.gameObject.SetActive(true);
        }
        
        int index = SceneManager.GetActiveScene().buildIndex;
        ActivateMenu();
        levelText.text = levelText.text + index.ToString();
        
    }

    public void Mute()
    {
        PlayerPrefs.SetInt("muteControl", 1);
        demute.gameObject.SetActive(true);
        mute.gameObject.SetActive(false);
    }
    public void DeMute()
    {
        PlayerPrefs.SetInt("muteControl", 0);
        demute.gameObject.SetActive(false);
        mute.gameObject.SetActive(true);

    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ActivateMenu()
    {
        menuUI.SetActive(true);
        DeActivateInGame();
    }
    public void DeActivateMenu()
    {
        menuUI.SetActive(false);
        ActivateInGame();
        GameManager.isStarted = true;
    }
    void ActivateInGame()
    {
        inGameUI.SetActive(true);
    }
    void DeActivateInGame()
    {
        inGameUI.SetActive(false);
    }
}
