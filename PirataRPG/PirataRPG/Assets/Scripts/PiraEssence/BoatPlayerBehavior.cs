using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatPlayerBehavior : MonoBehaviour
{

    public int HitPoints = 3;
    float _speed = 10f;
    Vector3 _deltaPos;
    private Animator animator;
    const float VERTICALUPPERLIMIT = 4f, VERTICALLOWERLIMIT = -4f;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _deltaPos = new Vector3(0, Input.GetAxis("Vertical") * _speed * Time.deltaTime);

        animator.SetFloat("orientation", _deltaPos.y);
        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, Mathf.Clamp(gameObject.transform.position.y, VERTICALLOWERLIMIT, VERTICALUPPERLIMIT));

    }

    public void OnHitted()
    {
        HitPoints--;
        Destroy(GameObject.Find("HitPoints").transform.GetChild(0).gameObject);

        if (HitPoints == 0)
        {
            Destroy(gameObject);
        }
    }
}
