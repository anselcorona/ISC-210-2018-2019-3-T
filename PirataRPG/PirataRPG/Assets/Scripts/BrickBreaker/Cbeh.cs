using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cbeh : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "CannonBall")
        {
            Destroy(this.gameObject);
        }
    }
}
