using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Scorez
{
    public float Time;
    public string name;
    public float Points;
}
public class BottomTriggerBehavior : MonoBehaviour
{
    public GameObject CannonBall;
    public GameObject Player;
    UnityWebRequest www;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
    }
    IEnumerator SendPostRequest(string url)
    {
        Scorez newScore = new Scorez
        {
            Time = 2f,
            Points = 0,
            name = "Ansel"
        };

        www = UnityWebRequest.Put(url, JsonUtility.ToJson(newScore));
        www.SetRequestHeader("Content-Type", "application/json");

        yield return www.SendWebRequest();

        Debug.Log(www.downloadHandler.text);
    }
}
