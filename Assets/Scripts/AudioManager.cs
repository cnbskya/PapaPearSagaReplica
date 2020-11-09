using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;    
    public AudioClip[] CollisionSounds;
    public AudioClip[] HoleSounds;
    private AudioSource audioSource;

    private void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    
    public void PlayHazelObstacleSound()
    {
        audioSource.PlayOneShot(CollisionSounds[0], 1);
    }
    public void PlayCarrotObstacleSound()
    {
        audioSource.PlayOneShot(CollisionSounds[1], 1);
    }

    public void PlayCircleColObstacleSound()
    {
        audioSource.PlayOneShot(CollisionSounds[2],1);
    }

    public void PlayBlueHole()
    {
        audioSource.PlayOneShot(HoleSounds[0]);
    }public void PlayOrangeHole()
    {
        audioSource.PlayOneShot(HoleSounds[1]);
    }public void PlayPinkHole()
    {
        audioSource.PlayOneShot(HoleSounds[2],0.5f);
    }public void PlayRedHole()
    {
        audioSource.PlayOneShot(HoleSounds[3]);
    }public void PlayGreenHole()
    {
        audioSource.PlayOneShot(HoleSounds[4]);
    }
}
