using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBEH : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cannonball")
        {
            Destroy(this.gameObject);
        }
    }
}
