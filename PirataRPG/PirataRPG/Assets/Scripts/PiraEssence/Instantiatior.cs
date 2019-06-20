using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiatior : MonoBehaviour
{
    public List<GameObject> Essences;
    public GameObject Spike;
    float _spikeRatio = 0.3f;
    const int _essenceQuantity = 6;
    float _nextTime;
    const float _LOWERTIME = 0.1f, _UPPERTIME = 2F;
    const float VERTICALUPPERLIMIT = 4f, VERTICALLOWERLIMIT = -4f;
    GameObject _newObject;

    void Start()
    {
        StartCoroutine(InstatiatorCoroutine());
    }

    void Update()
    {
        
    }

    IEnumerator InstatiatorCoroutine()
    {
        _nextTime = Random.Range(_LOWERTIME, _UPPERTIME);

        while (true)
        {
            yield return new WaitForSeconds(_nextTime);

            if(Random.Range(0f, 1f) <= _spikeRatio % 3)
            {
                _newObject = Spike;
            }
            else
            {
                _newObject = Essences[Random.Range(0, 6)];
            }
            Instantiate(_newObject, new Vector3(11f, Random.Range(VERTICALLOWERLIMIT, VERTICALUPPERLIMIT)), Quaternion.identity);

            _spikeRatio *= 1.1f;
        }
    }
}
