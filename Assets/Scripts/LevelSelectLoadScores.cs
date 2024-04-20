using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using TMPro;

public class LevelSelectLoadScores : MonoBehaviour
{

    public Dictionary<int, GameObject> levelTextObjects = new Dictionary<int, GameObject>();

    void Start()
    {
        foreach (Transform child in transform)
        {
            Match match = Regex.Match(child.name, @"Level(\d+)BestTimeText");
            if (match.Success)
            {
                int levelNumber = int.Parse(match.Groups[1].Value);
                levelTextObjects[levelNumber] = child.gameObject;
                child.gameObject.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("LevelCompleted_" + levelNumber, "---");
            }
        }
    }

    void Update()
    {
        
    }
}
