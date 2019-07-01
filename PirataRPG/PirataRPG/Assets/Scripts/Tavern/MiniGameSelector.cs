using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameSelector : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(this.gameObject.name);
        if (!Input.GetButtonDown("Submit"))
            return;
        else
        {
            switch (this.gameObject.name)
            {
                case "PiraPongSelector":
                    SceneManager.LoadScene(3);
                    break;
                case "PiraEssenceSelector":
                    SceneManager.LoadScene(2);
                    break;
                case "PiraBrickBreakerSelector":
                    SceneManager.LoadScene(4);
                    break;
            }
        }
    }
}
