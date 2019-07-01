using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBBallBehavior : MonoBehaviour
{
    public TextMesh startText;
    private float _startingSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            startText.text = "";
            gameObject.transform.SetParent(null);
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(_startingSpeed, _startingSpeed);

        }
    }
    public void UpdateBallState()
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
