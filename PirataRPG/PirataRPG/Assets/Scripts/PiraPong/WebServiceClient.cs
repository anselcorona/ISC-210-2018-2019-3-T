using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Scores
{
    public int IdScore;
    public string PlayerName;
    public double Score;
}
public class WebServiceClient : MonoBehaviour
{
    string url = "http://localhost:3000/api/Scores";

    UnityWebRequest www;

    GlobalScript globalScript;

    void Awake()
    {
        globalScript = Camera.main.GetComponent<GlobalScript>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            StartCoroutine(SendPostRequest(url));
        }
    }

    IEnumerator SendRequest(string url)
    {
        UnityWebRequest webRequest = UnityWebRequest.Get(url);

        yield return webRequest.SendWebRequest();

        if (www.isHttpError || www.isNetworkError)
            Debug.Log("No se logro obtener el listado de los jugadores");

        else
            Debug.Log(webRequest.downloadHandler.text);
    }

    IEnumerator SendPostRequest(string url)
    {
        Scores newScore = new Scores
        {
            PlayerName = "ë- Ansël Corona -ë",
            Score = globalScript.LeftScore
        };
        
        www = UnityWebRequest.Put(url, JsonUtility.ToJson(newScore));
        www.SetRequestHeader("Content-Type", "application/json");

        yield return www.SendWebRequest();

        Debug.Log(www.downloadHandler.text);
    }
}
