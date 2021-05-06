using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour
{

    public MeshRenderer blue;
    public MeshRenderer green;
    public MeshRenderer orange;
    public MeshRenderer purple;
    public MeshRenderer red;

    [Header("Transforms")]
    public Transform cubes;
    public Transform solvedCubes;

    public List<GameObject> CubesList = new List<GameObject>();
    public List<GameObject> SolvedCubesList = new List<GameObject>();

    GameManager gameManager;

    bool isCompleted;
    bool[] check;


    void AddDescendantsWithTag(Transform parent, string tag, List<GameObject> list)
    {
        foreach (Transform child in parent)
        {
            if (child.gameObject.tag == tag)
            {
                list.Add(child.gameObject);

            }
            AddDescendantsWithTag(child, tag, list);
        }
    }

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        AddDescendantsWithTag(cubes, "Cubes", CubesList);
        AddDescendantsWithTag(solvedCubes, "SolvedCubes", SolvedCubesList);
        check = new bool[CubesList.Count];
    }

    private void Update()
    {
        if (GameManager.isStarted)
        {
            for (int i = 0; i < CubesList.Count; i++)
            {

                if (CubesList[i].GetComponent<MeshRenderer>().material.color == SolvedCubesList[i].GetComponent<MeshRenderer>().material.color)
                {
                    check[i] = true;
                }
                else
                {
                    check[i] = false;
                }

            }
        }


        if (CheckColors() && GameManager.isStarted)
        {
            StartCoroutine(ControlPoint());
        }

    }

    IEnumerator ControlPoint()
    {

        yield return new WaitForSeconds(1f);
        if (CheckColors())
        {
            gameManager.NextLevel();
        }


    }


    bool CheckColors()
    {

        for (int i = 0; i < CubesList.Count; i++)
        {
            if (!check[i])
            {
                return false;
            }
        }
        return true;

    }

}
