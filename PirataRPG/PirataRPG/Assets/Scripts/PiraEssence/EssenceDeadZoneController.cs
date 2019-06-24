using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssenceDeadZoneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy"
            || other.gameObject.tag == "Yellow"
            || other.gameObject.tag == "Green"
            || other.gameObject.tag == "Red"
            || other.gameObject.tag == "Blue"
            || other.gameObject.tag == "Purple"
            || other.gameObject.tag == "Orange")
            Destroy(other.gameObject);
    }
}
