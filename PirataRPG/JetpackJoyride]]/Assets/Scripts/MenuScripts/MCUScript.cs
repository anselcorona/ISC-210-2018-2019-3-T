using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCUScript : MonoBehaviour
{
    float angulo;
    float velocidad = (2 * Mathf.PI) / 3;
    float x, y;


    // Update is called once per frame
    void Update()
    {
        angulo += velocidad * Time.deltaTime;
        x = Mathf.Cos(angulo) * 5f;
        y = Mathf.Sin(angulo) * 5f;
        gameObject.transform.position = new Vector3(x, y);
    }
}
