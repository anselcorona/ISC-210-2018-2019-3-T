using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBBallBehavior : MonoBehaviour
{
    public TextMesh startText;
    private float _startingSpeed = 8f;
    public float startTime = 0f;
    bool gameStarted = false;
    ScoreControl scoreControl;

    private void Awake()
    {
        scoreControl = GameObject.Find("BBackground").GetComponent<ScoreControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            startText.text = "";
            gameObject.transform.SetParent(null);
            if (!gameStarted)
            {
                gameStarted = !gameStarted;
                scoreControl.StartTime = Time.timeSinceLevelLoad;
            }
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(_startingSpeed, _startingSpeed);

        }
    }
    public void UpdateBallState()
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
