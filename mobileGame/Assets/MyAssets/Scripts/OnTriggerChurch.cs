using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerChurch: MonoBehaviour
{
    public AudioSource bellSound;

    private void OnTriggerEnter(Collider other)
    {
        bellSound.Play();
    }

}

