using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class CubeManager : MonoBehaviour
{
    AudioSource audioSource;


    private void Awake()
    {
        this.tag = transform.parent.tag;
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            audioSource.Play();
        }
    }


}
