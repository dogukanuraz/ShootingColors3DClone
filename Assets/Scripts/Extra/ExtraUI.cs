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
        value = 0;
        levelGenerator = FindObjectOfType<LevelGenerator>();
    }

    public void CurrentValue()
    {
        value = shooterDropdown.value;
        Debug.Log(value);

    }

    public void GenerateLevel()
    {
        levelGenerator.GenerateCube(value + 1);
        levelGenerator.GenerateCannon(value + 1);
    }

}
