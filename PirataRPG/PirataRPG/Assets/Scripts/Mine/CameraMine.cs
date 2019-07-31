using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMine : MonoBehaviour
{

    const float MINX = 8.17f, MINY=-15.6f, MAXX=30.57f, MAXY=-4.34f;
    public GameObject Player;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(Mathf.Clamp(Player.transform.position.x, MINX,MAXX), Mathf.Clamp(Player.transform.position.y, MINY, MAXY), -10f);

    }
}
