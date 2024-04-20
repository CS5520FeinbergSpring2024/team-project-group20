using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using TMPro;

public class LevelCompleteMenuScript : MonoBehaviour
{

    [SerializeField] private String currentSceneName;
    [SerializeField] LevelManager levelManager;

    void Start(){
        Time.timeScale = 0f;
        Match match = Regex.Match(currentSceneName, @"Map(\d+)");
        PlayerPrefs.SetString("LevelCompleted_" + match.Groups[1].Value, levelManager.timerText.GetComponent<TMPro.TextMeshProUGUI>().text);
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
