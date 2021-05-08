using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject cube;
    public GameObject cannon;
    public GameObject cubeParent;
    public GameObject solvedCubeParent;

    LevelManager levelManager;
    Color cannonColor;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    public void GenerateCube(int value)
    {
        int cubeSize = 0;


        for (float j = -0.5f; j < 5f; j += 0.5f)
        {
            var colorStatu = (ColorStatu)Random.Range(1, 4);
            GameObject blankCube = Instantiate(cube, transform);
            blankCube.GetComponent<CubeColor>().color.colorStatu = ColorStatu.BLANK;
            blankCube.transform.parent = cubeParent.transform;
            blankCube.transform.localPosition = new Vector3(0, 0, j);


            GameObject puzzleCube = Instantiate(cube, transform);
            //puzzleCube.GetComponent<MeshRenderer>().sharedMaterial = levelManager.blue.sharedMaterial;
            puzzleCube.GetComponent<CubeColor>().color.colorStatu = colorStatu;
            puzzleCube.transform.parent = solvedCubeParent.transform;
            puzzleCube.transform.localPosition = new Vector3(0, 0, j);

            GameObject generetedCannon = Instantiate(cannon, transform);
            generetedCannon.GetComponent<Cannon>().color.colorStatu = colorStatu;
            generetedCannon.transform.parent = cubeParent.transform;
            generetedCannon.transform.localPosition = new Vector3(1, 0, j);
            generetedCannon.transform.Rotate(0f, 270f, 0f);


            
            cubeSize++;

            if (cubeSize == value)
            {
                return;
            }
        }

        


    }

    //public void GenerateCannon(int value, Material material)
    //{
    //    Debug.Log("Çalýþýyor");
    //    int cannonSize = 0;


    //    for (float j = -0.5f; j < 3f; j += 0.5f)
    //    {
    //        GameObject generetedCannon = Instantiate(cannon, transform);
    //        generetedCannon.transform.parent = cubeParent.transform;
    //        generetedCannon.GetComponentInChildren<MeshRenderer>().material = material;

    //        generetedCannon.transform.localPosition = new Vector3(1, 0, j);
    //        generetedCannon.transform.Rotate(0f, 270f, 0f);

    //        cannonSize++;

    //        if (cannonSize == value)
    //        {
    //            return;
    //        }
    //    }



    //}

}
