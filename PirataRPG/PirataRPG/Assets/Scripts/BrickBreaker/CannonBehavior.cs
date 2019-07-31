using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehavior : MonoBehaviour
{

    public GameObject bolita;
    const float _LOWERTIME = 0.1f, _UPPERTIME = 2F;
    float _nextTime;

    float xpos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xpos = Mathf.PingPong(Time.time, 16f - 8);
        gameObject.transform.position = new Vector3(xpos, gameObject.transform.position.y);
    }
    IEnumerator InstatiatorCoroutine()
    {
        _nextTime = Random.Range(_LOWERTIME, _UPPERTIME);

        while (true)
        {
            yield return new WaitForSeconds(_nextTime);

            Instantiate(bolita, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);

        }
    }
}
