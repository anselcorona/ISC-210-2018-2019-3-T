using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChoicesScript : MonoBehaviour
{
    List<AudioSource> audioSources;



    private void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        switch (gameObject.name)
        {
            case "PlayButton":
                SceneManager.LoadScene(0);
                break;
            case "LeaderBoard":
                SceneManager.LoadScene(2);
                break;
            case "LeaderBoardOutline":
                SceneManager.LoadScene(2);
                break;
            case "back":
                SetAudioMute();
                SceneManager.LoadScene(1);
                break;
        }
    }
    private void SetAudioMute()
    {
        AudioSource[] sources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        for (int index = 0; index < sources.Length; ++index)
        {
            sources[index].Stop();
        }
    }
}

