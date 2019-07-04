using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    ScoreControl scoreControl;

    private void Awake()
    {
       scoreControl = GameObject.Find("Player").GetComponent<ScoreControl>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            scoreControl.addPoint();
        }
    }
}
