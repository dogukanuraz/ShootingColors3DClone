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


    private void Start()
    {
        int index = SceneManager.GetActiveScene().buildIndex + 1;
        ActivateMenu();
        levelText.text = levelText.text + index.ToString();
        
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
