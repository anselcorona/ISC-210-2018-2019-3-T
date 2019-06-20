using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBehavior : MonoBehaviour
{
    float accelX = -10f;
    float currentSpeedX = 0f;
    float deltaX;
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
        deltaX = currentSpeedX * Time.deltaTime + accelX*Mathf.Pow(Time.deltaTime, 2)/2;

        gameObject.transform.Translate(new Vector3(deltaX,0f));

        currentSpeedX += accelX * Time.deltaTime;
    }
}
