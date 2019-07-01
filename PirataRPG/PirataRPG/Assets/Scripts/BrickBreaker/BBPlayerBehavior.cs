using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBPlayerBehavior : MonoBehaviour
{
    const float RIGHTLIMIT = 7.5f;

    const float LEFTLIMIT = -7.5f;
    private float _speed = 10f;
    Vector3 _deltaPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        _deltaPos = new Vector3(Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0f);

        transform.Translate(_deltaPos);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, LEFTLIMIT, RIGHTLIMIT),transform.position.y, transform.position.z);
    }
}
