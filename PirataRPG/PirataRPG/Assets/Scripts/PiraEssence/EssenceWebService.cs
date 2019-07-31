using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Essences
{
    public int IdScore;
    public int Blue;
    public int Red;
    public int Yellow;
    public int Green;
    public int Orange;
    public int Purple;
    public string PlayerName;
}

    public class EssenceWebService : MonoBehaviour
{
    string url = "http://localhost:3000/api/Essences";

    UnityWebRequest www;

    ScoreController scoreController;

    void Awake()
    {
        scoreController = GameObject.Find("GlobalScripts").GetComponent<ScoreController>();
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
        Essences newEssence = new Essences
        {
            PlayerName = "ë- Ansël Corona -ë",
            Blue = scoreController.essenceScores["Blue"],
            Green = scoreController.essenceScores["Green"],
            Red = scoreController.essenceScores["Red"],
            Purple = scoreController.essenceScores["Purple"],
            Yellow = scoreController.essenceScores["Yellow"],
            Orange = scoreController.essenceScores["Orange"]
        };

        www = UnityWebRequest.Put(url, JsonUtility.ToJson(newEssence));
        www.SetRequestHeader("Content-Type", "application/json");

        yield return www.SendWebRequest();

        Debug.Log(www.downloadHandler.text);
    }
}
