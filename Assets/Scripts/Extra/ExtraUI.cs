using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExtraUI : MonoBehaviour
{
    public Dropdown shooterDropdown;
    int value;
    LevelGenerator levelGenerator;

    private void Start()
    {
        value = (int)Random.RandomRange(1,5);
        levelGenerator = FindObjectOfType<LevelGenerator>();
    }

    

    public void GenerateLevel()
    {
        GameManager.isStarted = true;
        levelGenerator.GenerateCube(value + 1);
        //levelGenerator.GenerateCannon(value + 1);
    }

}
