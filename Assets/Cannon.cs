using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CannonColor
{
    public ColorStatu colorStatu;
}

public class Cannon : MonoBehaviour
{
    public CannonColor color;
    LevelManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();

        switch (color.colorStatu)
        {
            case ColorStatu.BLANK:
                break;
            case ColorStatu.BLUE:
                gameObject.GetComponentInChildren<MeshRenderer>().sharedMaterial = levelManager.blue.sharedMaterial;
                break;
            case ColorStatu.GREEN:
                gameObject.GetComponentInChildren<MeshRenderer>().sharedMaterial = levelManager.green.sharedMaterial;
                break;
            case ColorStatu.ORANGE:
                gameObject.GetComponentInChildren<MeshRenderer>().sharedMaterial = levelManager.orange.sharedMaterial;
                break;
            case ColorStatu.PURPLE:
                gameObject.GetComponentInChildren<MeshRenderer>().sharedMaterial = levelManager.purple.sharedMaterial;
                break;
            case ColorStatu.RED:
                gameObject.GetComponentInChildren<MeshRenderer>().sharedMaterial = levelManager.red.sharedMaterial;
                break;
            default:
                break;
        }
    }
}
