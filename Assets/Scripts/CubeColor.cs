using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CubeColor : MonoBehaviour
{


    private void Awake()
    {
        this.tag = transform.parent.tag;
    }


    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<MeshRenderer>().material = other.GetComponent<MeshRenderer>().material;
    }
}
