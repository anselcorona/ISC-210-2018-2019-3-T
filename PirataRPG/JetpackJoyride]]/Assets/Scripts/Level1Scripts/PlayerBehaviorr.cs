using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviorr : MonoBehaviour
{

    float _speed = 5f;
    Vector3 _deltaPos;
    private Animator animator;
    private Rigidbody rigidbody;
    private MovingBackgroundScript movingBackgroundScript;
    const float VERTICALUPPERLIMIT = 4.5f, VERTICALLOWERLIMIT = -2.5f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        movingBackgroundScript = GameObject.Find("Background").GetComponent<MovingBackgroundScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            _deltaPos = new Vector3(0, _speed * Time.deltaTime);
            rigidbody.useGravity = false;
            rigidbody.isKinematic = true;
        }
        else
        {
            rigidbody.isKinematic = false;
            rigidbody.useGravity = true;
        }
        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, Mathf.Clamp(gameObject.transform.position.y, VERTICALLOWERLIMIT, VERTICALUPPERLIMIT));
        animator.SetFloat("Height", gameObject.transform.position.y);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            animator.SetBool("isDead", true);
            movingBackgroundScript.TurnOff();
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }
   
}
