using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ColorStatu
{
    BLANK,
    BLUE,
    GREEN,
    ORANGE,
    PURPLE,
    RED
}

[System.Serializable]
public class SelectColor
{
    public ColorStatu colorStatu;
}

public class CubeColor : MonoBehaviour
{
    public SelectColor color;
    LevelManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();

        switch (color.colorStatu)
        {
            case ColorStatu.BLANK:
                break;
            case ColorStatu.BLUE:
                gameObject.GetComponent<MeshRenderer>().sharedMaterial = levelManager.blue.sharedMaterial;
                break;
            case ColorStatu.GREEN:
                gameObject.GetComponent<MeshRenderer>().sharedMaterial = levelManager.green.sharedMaterial;
                break;
            case ColorStatu.ORANGE:
                gameObject.GetComponent<MeshRenderer>().sharedMaterial = levelManager.orange.sharedMaterial;
                break;
            case ColorStatu.PURPLE:
                gameObject.GetComponent<MeshRenderer>().sharedMaterial = levelManager.purple.sharedMaterial;
                break;
            case ColorStatu.RED:
                gameObject.GetComponent<MeshRenderer>().sharedMaterial = levelManager.red.sharedMaterial;
                break;
            default:
                break;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().material = other.GetComponent<MeshRenderer>().material;
    }
}
