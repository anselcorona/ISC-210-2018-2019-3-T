using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource EssenceGrabSound;
    public AudioSource BoatHit;
    public AudioSource BoatExploded;
    public AudioSource BackgroundMusic;


    public void PlayEssenceGrabSound()
    {
        EssenceGrabSound.Play();
    }
    public void PlayBoatHit()
    {
        BoatHit.Play();
    }
    public void PlayBoatExploded()
    {
        BoatExploded.Play();
    }
    public void PlayBackgroundMusic()
    {
        BackgroundMusic.Play();
    }
}
