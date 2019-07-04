using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Row;
    public GameObject BigSquare;
    public GameObject HollowSquare;

    float _nextTime, ypos = 0;
    const float _LOWERTIME = 1.2f, _UPPERTIME = 8F;
    const float UPPER_LIMIT = 4f, LOWER_LIMIT = 0f;
   

    private void Start()
    {
        StartCoroutine(InstantiatorCoroutine());
    }

    private void Update()
    {
        ypos = Mathf.PingPong(0, UPPER_LIMIT);
        Debug.Log(ypos);
    }

    IEnumerator InstantiatorCoroutine()
    {
        _nextTime = Random.Range(_LOWERTIME, _UPPERTIME);

        while (true)
        {
            int rand = Random.Range(0, 2);
            yield return new WaitForSeconds(_nextTime);

            if (rand == 0)
                Instantiate(Row, new Vector3(9.1f, ypos), Quaternion.identity);
            else if (rand == 1)
                Instantiate(BigSquare, new Vector3(9.1f, ypos), Quaternion.identity);
            else if (rand == 2)
                Instantiate(HollowSquare, new Vector3(9.1f, ypos), Quaternion.identity);

        }
    }
}
