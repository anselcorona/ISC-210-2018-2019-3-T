using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LeaderBoardLoader : MonoBehaviour
{

    string nameresults = "", scoreresults = "", coinresults="";
    string url = "http://localhost:3000/api/Scores?filter=%7B%22order%22%3A%22Coins%20DESC%22%7D";
    public TextMesh NameBoard;
    public TextMesh DistanceBoard;
    public TextMesh CoinsBoard;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SendRequest(url));
    }

    [Serializable]
    public class Score
    {
        public string PlayerName;
        public float DistanceRan;
        public int Coins;
    }



    IEnumerator SendRequest(string url)
    {
        UnityWebRequest webRequest = UnityWebRequest.Get(url);

        yield return webRequest.SendWebRequest();

        if (webRequest.isHttpError || webRequest.isNetworkError)
            Debug.Log("No se logro obtener el listado de los jugadores");

        else
        {
            Debug.Log(webRequest.downloadHandler.text);
            string responsee = webRequest.downloadHandler.text;
            string[] lest = responsee.Split('{');
            for(int i = 1; i< lest.Length; i++)
            {
                string[] elements = lest[i].Split('"');
                nameresults += i;
                nameresults += ". ";
                nameresults += elements[3].Substring(0,(elements[3].Length>8? 8: elements[3].Length-1));
                nameresults += "\n";
                scoreresults += elements[6].Substring(1, elements[6].Length - 2);
                scoreresults += "m\n";
                coinresults += elements[8].Substring(1, elements[8].Length - 2);
                coinresults += "\n";
            }
            NameBoard.text = nameresults;
            DistanceBoard.text = scoreresults;
            CoinsBoard.text = coinresults;
        }

    }



}
