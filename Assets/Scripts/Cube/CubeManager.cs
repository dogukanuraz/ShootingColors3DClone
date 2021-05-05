using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private void Awake()
    {
        this.tag = transform.parent.tag;
    }
}
