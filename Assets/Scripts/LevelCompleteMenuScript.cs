using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteMenuScript : MonoBehaviour
{

    [SerializeField] private String currentSceneName;

    void Start(){
        Time.timeScale = 0f;
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
