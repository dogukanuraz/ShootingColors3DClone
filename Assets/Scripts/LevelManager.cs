using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform cubes;
    public Transform solvedCubes;

    public List<GameObject> CubesList = new List<GameObject>();
    public List<GameObject> SolvedCubesList = new List<GameObject>();

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
        AddDescendantsWithTag(cubes, "Cubes", CubesList);
        AddDescendantsWithTag(solvedCubes, "SolvedCubes", SolvedCubesList);
        check = new bool[CubesList.Count];
    }

    private void Update()
    {

        for (int i = 0; i < CubesList.Count; i++)
        {

            if (CubesList[i].GetComponent<MeshRenderer>().material.color == SolvedCubesList[i].GetComponent<MeshRenderer>().material.color)
            {
                check[i] = true;
            }

        }

        if (CheckColors())
        {
            Debug.Log("success");
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
