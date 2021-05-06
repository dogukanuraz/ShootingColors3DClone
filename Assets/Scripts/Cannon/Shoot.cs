using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject cannonBall;

    Material cannonMat;
    Rigidbody cannonBallRB;
    float speed = 5;

    private void Start()
    {
        cannonBallRB = cannonBall.GetComponent<Rigidbody>();
        cannonMat = GetComponentInChildren<MeshRenderer>().material;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.isStarted)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider == gameObject.GetComponent<Collider>())
                {
                    Rigidbody instantiate = Instantiate(cannonBallRB, transform.position, transform.rotation) as Rigidbody;
                    instantiate.velocity = transform.TransformDirection(Vector3.forward * speed);
                    instantiate.GetComponent<MeshRenderer>().material = cannonMat;
                }
            }


        }
    }

    private void OnMouseDown()
    {
        //Rigidbody instantiate = Instantiate(cannonBallRB, transform.position, transform.rotation) as Rigidbody;
        //instantiate.velocity = transform.TransformDirection(Vector3.forward * speed);
        //instantiate.GetComponent<MeshRenderer>().material = cannonMat;
    }
}
