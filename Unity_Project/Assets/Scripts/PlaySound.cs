using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;
    public void Play()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
        else
            audioSource.Play();
    }
}
