using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    public TextMesh CoinText;
    public TextMesh DistanceText;
    public int Coins;
    // Start is called before the first frame update
    void Start()
    {
        Coins = 0;
    }

    public void addPoint()
    {
        Coins++;
        CoinText.text = Coins.ToString();
    }
}

