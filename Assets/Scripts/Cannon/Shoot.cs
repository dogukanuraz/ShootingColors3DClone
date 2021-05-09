using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using MoreMountains.NiceVibrations;

public class Shoot : MonoBehaviour
{

    public GameObject cannonBall;

    Material cannonMat;
    Rigidbody cannonBallRB;
    float speed = 5;

    private void Start()
    {
        cannonBallRB = cannonBall.GetComponent<Rigidbody>();
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
                    //MMVibrationManager.Haptic(HapticTypes.MediumImpact);
                    Rigidbody instantiate = Instantiate(cannonBallRB, transform.position, transform.rotation) as Rigidbody;
                    instantiate.transform.parent = this.transform;
                    instantiate.velocity = transform.TransformDirection(Vector3.forward * speed);
                    instantiate.GetComponent<MeshRenderer>().material = GetComponentInChildren<MeshRenderer>().material;
                }
            }


        }
    }

    
}
