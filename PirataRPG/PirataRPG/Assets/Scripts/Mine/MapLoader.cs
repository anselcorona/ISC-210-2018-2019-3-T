using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System;

public class MapLoader : MonoBehaviour
{

    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject F;
    public GameObject G;
    public GameObject H;
    public GameObject I;
    public GameObject J;
    public GameObject K;
    public GameObject L;
    public GameObject M;
    public GameObject N;
    public GameObject O;
    public GameObject P;
    public GameObject Q;
    public GameObject R;
    public GameObject S;
    public GameObject T;
    public GameObject U;
    XmlDocument xmlDoc;
    const string xmlPath = "Mine";
    GameObject newCell;
    public GameObject Player;

    private void Awake()
    {
        xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(Resources.Load<TextAsset>(xmlPath).text);
    }
    // Start is called before the first frame update
    void Start()
    {
        LoadMap(0, 40, 0, 21 );
    }

    void LoadMap(int xFrom, int xTo, int yFrom, int yTo)
    {
        int xFromCopy = xFrom;

        var selectedNodes = xmlDoc.SelectNodes(string.Format("//map/row[position()>={0} and position()<={1}]", yFrom, yTo));
        foreach (XmlNode currentNode in selectedNodes)
        {
            for (xFrom = xFromCopy; xFrom <= xTo && xFrom < currentNode.InnerText.Length; xFrom++)
            {
                switch (currentNode.InnerText[xFrom])
                {
                    case 'C':
                        newCell = C;
                        break;
                    case 'D':
                        newCell = D;
                        break;
                    case 'E':
                        newCell = E;
                        break;
                    case 'F':
                        newCell = F;
                        break;
                    case 'G':
                        newCell = G;
                        break;
                    case 'H':
                        newCell = H;
                        break;
                    case 'I':
                        newCell = I;
                        break;
                    case 'J':
                        newCell = J;
                        break;
                    case 'K':
                        newCell = K;
                        break;
                    case 'L':
                        newCell = L;
                        break;
                    case 'M':
                        newCell = M;
                        break;
                    case 'N':
                        newCell = N;
                        break;
                    case 'O':
                        newCell = O;
                        break;
                    case 'P':
                        newCell = P;
                        break;
                    case 'Q':
                        newCell = Q;
                        break;
                    case 'R':
                        newCell = R;
                        break;
                    case 'S':
                        newCell = S;
                        break;
                    case 'T':
                        newCell = T;
                        break;
                    case 'U':
                        newCell = U;
                        break;
                }
                Instantiate(newCell, new Vector3(xFrom, -yFrom), Quaternion.identity);
            }
            yFrom++;
        }
        selectedNodes = xmlDoc.SelectNodes(string.Format("//level/characters/character"));

        foreach (XmlNode currentNode in selectedNodes)
        {
            switch (currentNode.Attributes["prefabName"].Value)
            {
                case "Player":
                    newCell = Player;
                    break;
            }
            newCell = Instantiate(newCell, new Vector3(Convert.ToSingle(currentNode.Attributes["posX"].Value), -Convert.ToSingle(currentNode.Attributes["posY"].Value)), Quaternion.identity);
            newCell.name = currentNode.Attributes["uniqueObjectName"].Value;
            newCell.tag = currentNode.Attributes["tag"].Value;
        }
    }
}
