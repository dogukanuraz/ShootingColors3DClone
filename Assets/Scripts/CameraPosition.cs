using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void FixedUpdate()
    {
        transform.position = target.transform.position + offset;
        //if (target.tag == "Cubes")
        //{
        //    transform.LookAt(target);
        //}
        
    }
}
