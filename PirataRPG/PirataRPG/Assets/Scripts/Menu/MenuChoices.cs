using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuChoices : MonoBehaviour
{
    public MenuAudioManager menuAudioManager;
    public TextMesh textNormal;
    public TextMesh textRough;

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        switch (gameObject.name)
        {
            case "Play":
                menuAudioManager.PlayChoiceMade();
                SceneManager.LoadScene(1);
                break;
            case "MusicChoice":
                menuAudioManager.RoughBackgroundMusic.Stop();
                menuAudioManager.PlayChoiceMade();
                menuAudioManager.PlayNormalBackgroundMusic();
                textNormal.color = new Color(255,0,0);
                textRough.color = new Color(0, 0, 0);
                break;
            case "MusicChoice1":
                menuAudioManager.NormalBackgroundMusic.Stop();
                menuAudioManager.PlayChoiceMade();
                menuAudioManager.PlayRoughBackgroundMusic();
                textRough.color = new Color(255, 0, 0);
                textNormal.color = new Color(0, 0, 0);
                break;
            case "QuitGame":
                menuAudioManager.RoughBackgroundMusic.Stop();
                menuAudioManager.RoughBackgroundMusic.Stop();
                menuAudioManager.PlayChoiceMade();
                Application.Quit();
                break;
        }
    }
}
