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

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    public void GenerateCube(int value)
    {
        int cubeSize = 0;


        for (float j = -0.5f; j < 5f; j += 0.5f)
        {

            GameObject blankCube = Instantiate(cube, transform);
            blankCube.GetComponent<CubeColor>().color.colorStatu = ColorStatu.BLANK;
            blankCube.transform.parent = cubeParent.transform;
            blankCube.transform.localPosition = new Vector3(0, 0, j);


            GameObject puzzleCube = Instantiate(cube, transform);
            //puzzleCube.GetComponent<MeshRenderer>().sharedMaterial.color = levelManager.blue.sharedMaterial.color;
            puzzleCube.GetComponent<CubeColor>().color.colorStatu = ColorStatu.BLUE;
            puzzleCube.transform.parent = solvedCubeParent.transform;
            puzzleCube.transform.localPosition = new Vector3(0, 0, j);



            cubeSize++;

            if (cubeSize == value)
            {
                return;
            }
        }



    }
    public void GenerateCannon(int value)
    {
        int cannonSize = 0;


        for (float j = -0.5f; j < 3f; j += 0.5f)
        {
            GameObject generetedCannon = Instantiate(cannon, transform);
            generetedCannon.transform.parent = cubeParent.transform;

            generetedCannon.transform.localPosition = new Vector3(1, 0, j);
            generetedCannon.transform.Rotate(0f, 270f, 0f);

            cannonSize++;

            if (cannonSize == value)
            {
                return;
            }
        }



    }

}
