using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudioManager : MonoBehaviour
{
    public AudioSource NormalBackgroundMusic;
    public AudioSource RoughBackgroundMusic;
    public AudioSource ChoiceMade;

    private void Awake()
    {
        DontDestroyOnLoad(NormalBackgroundMusic);
        DontDestroyOnLoad(RoughBackgroundMusic);
        DontDestroyOnLoad(ChoiceMade);


    }



    public void PlayNormalBackgroundMusic()
    {
        NormalBackgroundMusic.Play();
    }
    public void PlayRoughBackgroundMusic()
    {
        RoughBackgroundMusic.Play();
    }
    public void PlayChoiceMade()
    {
        ChoiceMade.Play();
    }

}
