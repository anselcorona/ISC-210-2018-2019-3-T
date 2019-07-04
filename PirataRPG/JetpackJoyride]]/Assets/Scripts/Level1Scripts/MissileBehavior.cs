using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MissileBehavior : MonoBehaviour
{
    PlayerBehaviorr playerBehavior;
    ScoreControl scoreControl;
    float accelX = -5f;
    float currentSpeedX = 0f;
    float deltaX;

    private void Awake()
    {
        playerBehavior = GameObject.Find("Player").GetComponent<PlayerBehaviorr>();
        scoreControl = GameObject.Find("Player").GetComponent<ScoreControl>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //Vf = V0 + at
        currentSpeedX += accelX * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Xf = X0 + V0t + (at^2)/2
        deltaX = currentSpeedX * Time.deltaTime + accelX * Mathf.Pow(Time.deltaTime, 2) / 2;

        gameObject.transform.Translate(new Vector3(deltaX, 0f));

        currentSpeedX += accelX * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player" || other.gameObject.name != "warning")
            return;
        Destroy(gameObject);
        SendScore();
    }
    public class Score
    {
        public string PlayerName;
        public float DistanceRan;
        public int Coins;
    }
    IEnumerator SendScore()
    {
        Score newScore = new Score
        {
            PlayerName = "Ansël Corona",
            DistanceRan = 0,
            Coins = scoreControl.Coins
        };

        UnityWebRequest www = UnityWebRequest.Put("http://localhost:3000/api/Scores", JsonUtility.ToJson(newScore));
        www.SetRequestHeader("Content-Type", "application/json");

        yield return www.SendWebRequest();

        Debug.Log(www.downloadHandler.text);
    }
}
