using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBehavior : MonoBehaviour
{
    BoatPlayerBehavior boatPlayerBehavior;
    ScoreController scoreController;
    float accelX = -10f;
    float currentSpeedX = 0f;
    float deltaX;


    private void Awake()
    {
        boatPlayerBehavior = GameObject.Find("Player").GetComponent<BoatPlayerBehavior>();
        scoreController = GameObject.Find("GlobalScripts").GetComponent<ScoreController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Vf = V0 + at
        currentSpeedX += accelX * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        // Xf = X0 + V0t + (at^2)/2
        deltaX = currentSpeedX * Time.deltaTime + accelX*Mathf.Pow(Time.deltaTime, 2)/2;

        gameObject.transform.Translate(new Vector3(deltaX,0f));

        currentSpeedX += accelX * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player")
            return;

        if (gameObject.tag == "Spike")
            boatPlayerBehavior.OnHitted();
        else
            scoreController.AddEssence(gameObject.tag);
        Destroy(gameObject);
    }
}
