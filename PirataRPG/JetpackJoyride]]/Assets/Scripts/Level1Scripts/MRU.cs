using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRU : MonoBehaviour
{
    float deltaX;
    float SpeedX = -10f;


    // Update is called once per frame
    void Update()
    {
        deltaX = SpeedX * Time.deltaTime;
        gameObject.transform.Translate(new Vector3(deltaX, 0f));
    }
}
