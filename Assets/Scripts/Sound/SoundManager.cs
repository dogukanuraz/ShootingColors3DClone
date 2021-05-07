using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static bool isMute;

    AudioListener audioListener;

    

    private void Start()
    {
        audioListener = GetComponent<AudioListener>();        
    }

    private void Update()
    {

        if (isMute)
        {
            audioListener.enabled = false;
        }
        else
        {
            audioListener.enabled = true;
        }
    }
}
