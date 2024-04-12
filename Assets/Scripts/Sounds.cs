using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip[] sounds = new AudioClip[3];
    private AudioSource audioSrc => GetComponent<AudioSource>();
    public void PlaySound(AudioClip clip)
    {
        audioSrc.PlayOneShot(clip);
    }

}
