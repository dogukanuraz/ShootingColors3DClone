using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevelUI : MonoBehaviour
{

    public void SceneOne()
    {
        SceneManager.LoadScene(0);
    }
    public void SceneTwo()
    {
        SceneManager.LoadScene(1);
    }
    public void SceneThree()
    {
        SceneManager.LoadScene(2);
    }
    public void SceneFour()
    {
        SceneManager.LoadScene(3);
    }
    public void SceneFive()
    {
        SceneManager.LoadScene(4);
    }
    public void SceneExtra()
    {
        SceneManager.LoadScene(5);
    }
}
