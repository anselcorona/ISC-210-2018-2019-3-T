using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackgroundScript : MonoBehaviour
{
    private bool destroyed = false;
    public GameObject otherBG;
    private bool gameStarted;
    private bool keep = true;

    // Update is called once per frame
    void Update()
    {
        if (keep)
        {
            transform.Translate(-.1f, 0, 0);

            if (transform.position.x < 0 && !destroyed)
            {
                Instantiate(otherBG, new Vector3(21.72f, 0, 100), Quaternion.identity);
                destroyed = true;
            }

            if (transform.position.x < -19.77f)
            {
                Destroy(gameObject);
            }
        }
    }

    public void TurnOff()
    {
        keep = !keep;
    }
}
