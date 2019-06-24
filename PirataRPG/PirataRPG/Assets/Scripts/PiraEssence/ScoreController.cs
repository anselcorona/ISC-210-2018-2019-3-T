using System;
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
        ResetTextScores();
    }

    void ResetTextScores()
    {
        Blue.text = essenceScores["Blue"].ToString();
        Green.text = essenceScores["Green"].ToString();
        Red.text = essenceScores["Red"].ToString();
        Purple.text = essenceScores["Purple"].ToString();
        Yellow.text = essenceScores["Yellow"].ToString();
        Orange.text = essenceScores["Orange"].ToString();

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
                Green.text = essenceScores[essenceTag].ToString();
                break;
            case "Red":
                Red.text = essenceScores[essenceTag].ToString();
                break;
            case "Purple":
                Purple.text = essenceScores[essenceTag].ToString();
                break;
            case "Yellow":
                Yellow.text = essenceScores[essenceTag].ToString();
                break;
            case "Orange":
                Orange.text = essenceScores[essenceTag].ToString();
                break;

        }
    }
}
