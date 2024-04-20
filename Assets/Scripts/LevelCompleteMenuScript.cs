using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using TMPro;

//TimeSpan Docs
//https://learn.microsoft.com/en-us/dotnet/api/system.timespan?view=net-8.0

public class LevelCompleteMenuScript : MonoBehaviour
{

    [SerializeField] private String currentSceneName;
    [SerializeField] LevelManager levelManager;

    void Start(){
        Time.timeScale = 0f;
        Match match = Regex.Match(currentSceneName, @"Map(\d+)");
        string oldHighScore = PlayerPrefs.GetString("LevelCompleted_" + match.Groups[1].Value, "99:00");
        string newScore = levelManager.timerText.GetComponent<TMPro.TextMeshProUGUI>().text;
        TimeSpan newTime = TimeSpan.ParseExact(newScore, "mm':'ss", null);
        TimeSpan oldTime = TimeSpan.ParseExact(oldHighScore, "mm':'ss", null);
        if (TimeSpan.Compare(newTime, oldTime) < 0)
        {
            PlayerPrefs.SetString("LevelCompleted_" + match.Groups[1].Value, newScore);
        }

        
    }


    public void Restart()
    {
        
        SceneManager.LoadScene(currentSceneName);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        
        SceneManager.LoadScene("HomeScreen");
        Time.timeScale = 1f;

    }
}
