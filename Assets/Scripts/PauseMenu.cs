using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;
    [SerializeField] private String currentSceneName;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;

        //stop timer
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;

        // start timer
        EventManager.OnTimerStart();
    }

    public void Restart()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(currentSceneName);
        Time.timeScale = 1f;

    }

    public void Quit()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene("LevelSelector");
        Time.timeScale = 1f;

    }
}
