using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using TMPro;

public class LevelSelectLoadScores : MonoBehaviour
{

    void Start()
    {
        foreach (Transform child in transform)
        {
            Match match = Regex.Match(child.name, @"Level(\d+)BestTimeText");
            if (match.Success)
            {
                int levelNumber = int.Parse(match.Groups[1].Value);
                child.gameObject.GetComponent<TextMeshProUGUI>().text = "Best: " +  PlayerPrefs.GetString("LevelCompleted_" + levelNumber, "---");
            }
        }
    }

    void Update()
    {
        
    }
}
