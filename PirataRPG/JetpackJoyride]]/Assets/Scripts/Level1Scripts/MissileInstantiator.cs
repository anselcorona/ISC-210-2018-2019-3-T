using System.Collections;
using UnityEngine;

public class MissileInstantiator : MonoBehaviour
{

    public GameObject missile, warning; 
    float _nextTime, ypos = 0;
    const float _LOWERTIME = 1f, _UPPERTIME = 5F;
    const float UPPER_LIMIT = 4.5f, LOWER_LIMIT = -2.5f;

    private void Start()
    {
        StartCoroutine(InstantiatorCoroutine());
    }

    private void Update()
    {
        ypos = Random.Range(LOWER_LIMIT, UPPER_LIMIT);
        warning.transform.position = new Vector3(warning.transform.position.x, ypos, warning.transform.position.z);
    }

    IEnumerator InstantiatorCoroutine()
    {
        _nextTime = Random.Range(_LOWERTIME, _UPPERTIME);

        while (true)
        {
            GameObject gg = Instantiate(warning, new Vector3(8f, ypos), Quaternion.identity);

            yield return new WaitForSeconds(_nextTime);

            Instantiate(missile, new Vector3(9.1f, ypos), Quaternion.identity);
            Destroy(gg);
        }
    }
}
