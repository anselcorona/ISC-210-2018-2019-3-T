using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Scorez
{
    public string Time;
    public string name;
    public int Points;
}
public class BottomTriggerBehavior : MonoBehaviour
{
    public GameObject CannonBall;
    public GameObject Player;
    ScoreControl scoreControl;
    UnityWebRequest www;

    private void Awake()
    {
        scoreControl = GameObject.Find("BBackground").GetComponent<ScoreControl>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name != "Cannonball")
        {
            return;
        }

        CannonBall.transform.SetParent(Player.transform);
        CannonBall.transform.localPosition = new Vector3( 0f, 1.2f);
        CannonBall.SendMessage("UpdateBallState");
        StartCoroutine(SendPostRequest("http://localhost:3000/api/Scores"));
        //SceneManager.LoadScene(4);
    }
    IEnumerator SendPostRequest(string url)
    {
        Scorez newScore = new Scorez
        {
            Time = scoreControl.timer,
            Points = scoreControl.Score,
            name = "Ansel Corona"
        };

        www = UnityWebRequest.Put(url, JsonUtility.ToJson(newScore));
        www.SetRequestHeader("Content-Type", "application/json");

        yield return www.SendWebRequest();

        Debug.Log(www.downloadHandler.text);
    }
}
