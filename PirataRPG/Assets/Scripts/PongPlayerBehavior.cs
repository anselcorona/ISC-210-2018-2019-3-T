using UnityEngine;
using System.Collections;

public class PongPlayerBehavior : MonoBehaviour
{

    bool _isLeftPlayer;

    private float _speed = 10f;

    Vector3 _deltaPos;

    const float UPPERLIMIT = 3.38f;

    const float LOWERLIMIT = -3.38f;

    private bool _onePlayer;

    private GameObject _ball;

    private void Awake()
    {
        _isLeftPlayer = gameObject.name == "LeftPlayer";
        _ball  = GameObject.Find("Ball");
    }
    // Use this for initialization
    void Start()
    {
        _onePlayer = true;
    }

    // Update is called once per frame
    void Update()
    {
        float desde, hasta;
        desde = gameObject.transform.position.y < _ball.transform.position.y 
            ? gameObject.transform.position.y 
            : _ball.transform.position.y;
        hasta = gameObject.transform.position.y > _ball.transform.position.y 
            ? gameObject.transform.position.y 
            : _ball.transform.position.y;

        if(_onePlayer && !_isLeftPlayer)
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(Mathf.Lerp(desde, hasta, 0.5f), LOWERLIMIT, UPPERLIMIT), transform.position.z);
            return;
        }

        _deltaPos = new Vector3(0f,(_isLeftPlayer ? Input.GetAxis("LeftPlayer")  : Input.GetAxis("Vertical")) * _speed * Time.deltaTime);
        
        transform.Translate(_deltaPos); 


        transform.position = new Vector3(transform.position.x,
            Mathf.Clamp(transform.position.y,LOWERLIMIT,UPPERLIMIT),
               transform.position.z);
    }
}
