using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{

    public TextMesh BrickAmount;
    public TextMesh TimeSpent;
    public int Score;
    public string timer = "00:00";
    public float StartTime {get;set;}


    void Start()
    {
        Score = 0;
        BrickAmount.text = "0";
        TimeSpent.text = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if(StartTime <= 0f) {
            timer = "00:00";
        }
        else
        {
            timer = string.Format("{0:00}:{1:00}", ((Time.timeSinceLevelLoad - StartTime) / 60) % 60, (Time.timeSinceLevelLoad - StartTime) % 60);
        }
        TimeSpent.text = timer;
        BrickAmount.text = Score.ToString();
    }
    public void KillBrick()
    {
        Score++;
    }
    public void Reset()
    {
        Score = 0;
        BrickAmount.text = "0";
        TimeSpent.text = timer;
    }

}
