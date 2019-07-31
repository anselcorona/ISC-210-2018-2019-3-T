using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBEH : MonoBehaviour
{
    ScoreControl scoreControl;
    public GameObject cannon;

    private void Awake()
    {
        scoreControl = GameObject.Find("BBackground").GetComponent<ScoreControl>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cannonball" || collision.gameObject.name=="bolita")
        {
            if (gameObject.name == "cofre13")
            {
                Instantiate(cannon, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
            }
            Destroy(this.gameObject);
            scoreControl.KillBrick();
        }
    }
}
