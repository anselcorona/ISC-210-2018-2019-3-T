using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    Dictionary<string, int> essenceScores = 
        new Dictionary<string, int> 
        {
         {"Blue",0},
         {"Green",0},
         {"Yellow",0},
         {"Red",0},
         {"Purple",0},
         {"Orange",0} 
         };
    // Start is called before the first frame update

    public TextMesh Blue;
    public TextMesh Green;
    public TextMesh Yellow;
    public TextMesh Red;
    public TextMesh Purple;
    public TextMesh Orange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddEssence(string essenceTag)
    {
        essenceScores[essenceTag]++;

        switch (essenceTag)
        {
            case "Blue":
                Blue.text = essenceScores[essenceTag].ToString();
                break;
            case "Green":
                break;
            case "Red":
                break;
            case "Purple":
                break;
            case "Yellow":
                break;
            case "Orange":
                break;

        }
    }
}
