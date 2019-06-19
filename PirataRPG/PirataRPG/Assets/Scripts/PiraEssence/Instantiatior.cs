using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiatior : MonoBehaviour
{
    public List<GameObject> Essences;
    public GameObject Spike;
    const int _essenceQuantity = 6;
    float _nextTime;
    const float _LOWERTIME = 1f, _UPPERTIME = 2F;
    void Start()
    {
        StartCoroutine(InstatiatorCoroutine);
    }

    void Update()
    {
        
    }

    IEnumerator InstatiatorCoroutine()
    {

    }
}
