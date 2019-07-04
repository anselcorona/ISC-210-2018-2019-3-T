using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudioManager : MonoBehaviour
{
    public AudioSource BackgroundMusic;

    private void Awake()
    {
        DontDestroyOnLoad(BackgroundMusic);

    }

    public void PlayNormalBackgroundMusic()
    {
        BackgroundMusic.Play(); 
    }
}

